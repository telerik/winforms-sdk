using JustMock_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.JustMock;
using Telerik.WinControls.UI;
using static JustMock_Challenge.JMRadForm;

namespace UnitTestProjectChallenge
{
    [TestClass]
    public class UnitTestChallenge
    {

        [TestMethod]
        public void TestMethodSelectRows()
        {
            //Arrange 
            List<Order> myCollection = new List<Order>();
            myCollection.Add(new Order(1, DateTime.Now, new List<Product>()
            {
                new Product("Apple",1.45f ,3),
                new Product("Banana",3.15f ,2),
                new Product("Avocado",2.30f ,1),
                new Product("Cucumber",2.80f ,2)
            }));

            myCollection.Add(new Order(2, DateTime.Now, new List<Product>()
            {
                new Product( "Tomato",1.20f ,4),
                new Product( "Cucumber",2.80f ,2),
                new Product( "Orange",4.30f ,3)
            }));

            myCollection.Add(new Order(3, DateTime.Now, new List<Product>()
            {
                new Product( "Apple",1.45f ,4),
                new Product( "Avocado",2.30f ,2)
            }));

            myCollection.Add(new Order(4, DateTime.Now, new List<Product>()
            {
                new Product( "Banana",3.15f,4),
                new Product( "Mango",6.80f ,2)
            }));

            using (JMRadForm form = new JMRadForm())
            { 
                Mock.Arrange(() => form.GetData()).ReturnsCollection(myCollection);

                //Act 
                List<Order> orders = form.GetData();
                form.Grid.DataSource = orders;
                form.Grid.ClearSelection();
                form.Grid.MultiSelect = true;
                string productName = "Apple";
                form.SelectOrdersByProduct(productName); 

                //Assert            
                Assert.IsTrue(form.Grid.SelectedRows.Count == 2);
            }
        }

        [TestMethod]
        public void TestMethodNoSelection()
        { 
            //Arrange
            using (JMRadForm form = new JMRadForm())
            { 

                var order = Mock.Create<Order>();
                Mock.Arrange(() => order.ContainsProduct(Arg.AnyString)).IgnoreInstance().Returns(false);

                //Act 
                List<Order> orders = form.GetData();
                form.Grid.DataSource = orders;
                form.Grid.MultiSelect = true;
                string productName = "Apple";
                form.SelectOrdersByProduct(productName);

                //Assert            
                Assert.IsTrue(form.Grid.SelectedRows.Count == 0);
            }
        } 

        [TestMethod]
        public void TestMethodRaiseEvent()
        {
            //Arrange
            using (JMRadForm form = new JMRadForm())
            {
                List<Order> orders = form.GetData();
                form.Grid.DataSource = orders;
                form.Grid.ClearSelection();
                form.Grid.MultiSelect = false;
                form.Grid.CurrentRow = null;
                form.Grid.LoadElementTree();

                string actual = null;
                string expected = form.Grid.Rows[orders.Count / 2].Cells["Id"].Value+"";


                var executor = Mock.Create<RadGridView>();
                executor.CurrentRowChanged += delegate (object sender, CurrentRowChangedEventArgs args)
                {
                    if (args.CurrentRow!=null && args.CurrentRow.DataBoundItem == orders[orders.Count / 2])
                    {
                        actual = args.CurrentRow.Cells["Id"].Value + "";
                    }                   
                };

                // Act 

                CurrentRowChangedEventArgs eventArguments = new CurrentRowChangedEventArgs(null, form.Grid.Rows[orders.Count / 2]);
                Mock.Raise(() => executor.CurrentRowChanged += null, eventArguments);

                // Assert 
                Assert.AreEqual(expected, actual); 
                 
            }
        }

        [TestMethod]
        public void TestPrivateMethodGetTotalAmount()
        {
            //Arrange
            using (JMRadForm form = new JMRadForm())
            {
                List<Order> orders = form.GetData();
                form.Grid.DataSource = orders;

                //Create a mocked instance of your class under test 
                var orderMock = Mock.Create<Order>();
                //Arrange your expectations
                Mock.NonPublic.Arrange<float>(orderMock, "GetTotalAmount").Returns(5f);

                // Act 
                //Create new PrivateAccessor with the mocked instance as an argument
                var inst = new PrivateAccessor(orderMock);

                //Call the non-public method by giving its exact name
                var actual = inst.CallMethod("GetTotalAmount");

                // Assert 
                //Finally, you can assert against its expected return value
                Assert.AreEqual(5f, actual);

            }
        }

        [TestMethod]
        public void TestMethodSelectionChanged()
        {
            //Arrange
            using (JMRadForm form = new JMRadForm())
            {
                List<Order> orders = form.GetData();
                form.Grid.DataSource = orders;
                form.Grid.ClearSelection();
                form.Grid.CurrentRow = null;
                form.Grid.MultiSelect = false;
                form.Grid.LoadElementTree();
           
                //get the middle visual row element
                GridRowElement visualRowElement = form.Grid.TableElement.GetRowElement(form.Grid.Rows[orders.Count / 2]);
                var rowBehaviorMock = Mock.Create<GridRowBehavior>(Behavior.CallOriginal);
 
                Mock.NonPublic.Arrange<IGridBehavior>((BaseGridBehavior)form.Grid.GridBehavior, "GetRowBehaviorAtPoint", 
                    Arg.Expr.IsAny<Point>()).Returns(((BaseGridBehavior)form.Grid.GridBehavior).GetBehavior(visualRowElement.RowInfo.GetType()));
                Mock.NonPublic.Arrange<GridCellElement>(rowBehaviorMock, "GetCellAtPoint", Arg.Expr.IsAny<Point>()).IgnoreInstance().Returns(visualRowElement.VisualCells[1]);
                Mock.NonPublic.Arrange<GridRowElement>(rowBehaviorMock, "GetRowAtPoint", Arg.Expr.IsAny<Point>()).IgnoreInstance().Returns(visualRowElement);
 
                string middleRowText = visualRowElement.VisualCells[1].Text;
                string actual = string.Empty;
                form.Grid.SelectionChanged += (o, e) =>
                {
                    actual = form.Grid.SelectedRows[0].Cells["Id"].Value.ToString();
                };

                //Act
                MouseEventArgs emptyMouseEventArgs = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
                ((BaseGridBehavior)form.Grid.GridBehavior).OnMouseDown(emptyMouseEventArgs);
                 
                //Assert            
                Assert.AreEqual(middleRowText, actual);
            }
        }
    }
}
