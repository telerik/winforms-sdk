using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TrieImplementation.Tests
{
    [TestClass]
    public class TrieTests
    {
        #region InsertTests
        [TestMethod]
        public void InserWordTest()
        {
            Trie trie = new Trie();
            string word = "GOSHO";
            trie.Insert(word);

            Assert.AreEqual('G', trie.Root.Children['G'].Value);
        }

        #endregion

        #region ContainsTests

        [TestMethod]
        public void CheckIfContainsWordTest()
        {
            Trie trie = new Trie();
            string word = "GOSHO";
            trie.Insert(word);
            bool actual = trie.Contains(word);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTwoWordsAndTestIfContainsTest()
        {
            Trie trie = new Trie();
            string word = "GOSHO";
            trie.Insert(word);
            string word2 = "GOSHO2";
            trie.Insert(word2);
            bool actual = trie.Contains(word);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertTwoWordsAndTestIfContainsSecondWordTest()
        {
            Trie trie = new Trie();
            string word = "GOSHO";
            trie.Insert(word);
            string word2 = "GOSHO2";
            trie.Insert(word2);
            bool actual = trie.Contains(word2);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertTwoWordsAndTestIfNotContainsWordTest()
        {
            Trie trie = new Trie();
            string word = "GOSHO";
            trie.Insert(word);
            string word2 = "GOSHO2";
            trie.Insert(word2);
            bool actual = trie.Contains("HA");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void InsertWordWithSpaceAndCheckIfContains()
        {
            Trie trie = new Trie();
            string word = "GOSHO GOSHO";
            trie.Insert(word);
            bool actual = trie.Contains(word);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordWithSpaceAndCheckIfNoContains()
        {
            Trie trie = new Trie();
            string word = "GOSHO GOSHO";
            trie.Insert(word);
            bool actual = trie.Contains("GOSHO");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordWithSpaceAndCheckIfNoContainsSecond()
        {
            Trie trie = new Trie();
            string word = "GOSHO GOSHO";
            trie.Insert(word);
            bool actual = trie.Contains("GOSHO43rqefd");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void InsertNumbersAndCheckIfContains()
        {
            Trie trie = new Trie();
            string word = "123";
            trie.Insert(word);
            bool actual = trie.Contains("123");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertNumbersAndCheckIfNoContains()
        {
            Trie trie = new Trie();
            string word = "123";
            trie.Insert(word);
            bool actual = trie.Contains("1234");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void InsertReallyLongTextAndSearchForWord()
        {
            Trie trie = new Trie();
            string[] words = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam odio justo, sollicitudin porta adipiscing a, lobortis at velit. Quisque in enim eleifend, iaculis enim vel, consectetur nibh. Donec facilisis venenatis nisl. Maecenas non odio a mi tristique vulputate et eget lectus. Sed ullamcorper rhoncus nulla eget gravida. Suspendisse dapibus magna ut lorem eleifend, sed auctor nibh tristique. Donec sed quam viverra leo dapibus blandit. Quisque at elit porta, tincidunt ante quis, ornare orci. Vivamus iaculis feugiat neque at vestibulum.

Ut ut odio libero. Suspendisse eget ipsum ut tortor varius semper in non metus. Etiam mi lorem, interdum ut molestie ut, placerat ut tortor. Etiam facilisis, lacus vel sodales rutrum, nulla justo pretium metus, a aliquam risus purus vel urna. Morbi vel velit a ipsum fermentum posuere a id ante. Aliquam a nisi id metus scelerisque hendrerit non id purus. Vestibulum quis risus sed sapien tempor auctor. Vivamus est metus, viverra in ipsum ac, commodo suscipit eros.

Proin nec eros vel quam facilisis eleifend vel sit amet urna. Donec condimentum commodo eros vitae ultricies. Morbi tempor vestibulum diam, eget tincidunt quam consectetur non. Cras blandit urna elit, et pharetra dui vestibulum at. Vestibulum tincidunt interdum lorem a porta. Aliquam erat volutpat. Morbi id laoreet erat. Nunc in sem mi. Vestibulum volutpat congue eros. Proin ut suscipit augue, sed interdum dolor. Nam diam nulla, accumsan condimentum est vitae, ornare dapibus odio. Duis eu velit at arcu fringilla fermentum mollis quis velit. Donec nunc elit, vehicula et lobortis eget, laoreet aliquet orci.

Duis euismod consectetur quam non mattis. Etiam fringilla urna vitae elit tempus, a pharetra tortor mollis. Vestibulum consectetur sed ante nec aliquam. Vestibulum eleifend sit amet massa quis venenatis. Praesent porttitor sapien massa, at varius nisl interdum vitae. Vivamus posuere mi eget massa eleifend dictum. Pellentesque dapibus libero leo, in pretium augue feugiat quis. Mauris tempus luctus pulvinar. Quisque sem est, lacinia et lobortis quis, blandit vitae metus. Sed venenatis tristique orci. Praesent sit amet commodo arcu. Suspendisse imperdiet eu leo at bibendum. Phasellus quis tincidunt nibh. Suspendisse euismod elit sit amet enim vehicula, at dignissim sapien euismod.

Donec facilisis a sapien ullamcorper posuere. Morbi neque metus, malesuada a viverra eu, gravida pellentesque mauris. Sed sit amet aliquam turpis. Praesent vitae mauris orci. Mauris tristique volutpat lacinia. Quisque tincidunt libero et enim viverra dapibus. Donec pulvinar gravida tincidunt. Etiam purus est, adipiscing ac ornare non, fringilla quis arcu. Pellentesque gravida, eros in volutpat tincidunt, lectus risus posuere nisl, vel congue dui enim at quam.

Sed facilisis quam volutpat semper tempor. Morbi felis nisl, tempus bibendum vestibulum sed, tincidunt eget velit. Fusce eget nisi at augue blandit dictum. Cras ut orci justo. Vestibulum nec facilisis elit. Quisque vel neque congue, ultricies eros eu, faucibus ipsum. Vestibulum ut orci eget arcu viverra posuere.

Nullam iaculis mauris nec nisl tempor tincidunt. Nullam tristique neque vitae libero viverra, in facilisis magna pellentesque. Aliquam lacinia lacus urna, ut feugiat purus facilisis vitae. Pellentesque cursus lectus non lorem volutpat, vitae volutpat purus dictum. Sed at leo nec arcu volutpat eleifend. Phasellus gravida eleifend orci. Aliquam erat volutpat. Donec luctus vestibulum sapien, at vulputate purus. Suspendisse hendrerit diam eget mi ultricies eleifend. In ut dapibus metus. Nunc mollis nunc a enim molestie, a ultricies magna commodo.

Aenean ut nisi non urna ullamcorper posuere. Interdum et malesuada fames ac ante ipsum primis in faucibus. Cras ullamcorper justo varius consequat consectetur. Sed dui elit, hendrerit non libero nec, congue laoreet lorem. Pellentesque ut blandit nunc. Vestibulum volutpat sollicitudin elit quis pharetra. Ut nibh mi, pharetra non lacus vitae, rutrum commodo quam. Curabitur iaculis pellentesque metus nec sollicitudin. Duis eu turpis varius, auctor arcu vitae, tincidunt purus. Nullam tellus ante, molestie vitae eros ut, porta tempus quam. Nunc et nibh ut erat porta elementum in in nibh. Quisque consequat nisl ut turpis luctus, tristique vestibulum tortor tempus. Etiam feugiat vestibulum posuere. Aenean elit orci, convallis eu arcu sed, scelerisque rhoncus dolor. Sed euismod semper malesuada.

In dapibus cursus tempor. Donec volutpat viverra dui. Nulla facilisi. Pellentesque ornare consectetur luctus. Curabitur pulvinar pretium tincidunt. Pellentesque fermentum adipiscing lorem, a cursus nisl mattis non. Donec at pharetra odio.

Sed gravida dolor quis vehicula consequat. Fusce faucibus neque est, id ornare sem tincidunt at. Vestibulum ut egestas libero, at ornare orci. Interdum et malesuada fames ac ante ipsum primis in faucibus. Cras sem sem, ornare vel porttitor non, ultrices ac massa. Praesent posuere nisi lectus, non ornare massa pulvinar eu. Curabitur ipsum mauris, ultricies vitae viverra id, vulputate hendrerit enim. Proin non purus ac mi fringilla placerat ut vel nulla. Nulla euismod nisi id sollicitudin accumsan. Ut tempus venenatis libero eget rutrum. Ut lobortis euismod diam, vel cursus urna tincidunt vitae.

Vivamus a dictum nibh. Vivamus lorem leo, iaculis eleifend sagittis et, sodales eu lorem. Donec sit amet laoreet justo. Proin blandit convallis libero ac condimentum. Nam ultrices ut risus convallis porttitor. Maecenas ullamcorper bibendum neque, feugiat dignissim leo consequat non. Mauris nec placerat nisi. Interdum et malesuada fames ac ante ipsum primis in faucibus. Praesent venenatis justo ut odio commodo, in viverra elit accumsan. Aenean sit amet ante consectetur, molestie arcu nec, dapibus sapien. Quisque ac eros sodales nisi rhoncus eleifend ut at erat. Sed sit amet dictum sapien. Pellentesque auctor convallis dui, vitae rutrum metus feugiat in.

Proin rutrum nec orci et sagittis. Mauris ultrices erat tortor, vitae feugiat enim tincidunt id. Aliquam blandit sodales dui vel mattis. Ut dignissim ultrices lacus quis mollis. Suspendisse luctus commodo dui, a eleifend leo cursus eget. Phasellus eu accumsan diam. Aenean tempus suscipit purus et tristique. Vivamus sem tortor, porttitor elementum justo ut, ultricies ultrices purus.

Sed sed velit urna. Quisque hendrerit feugiat nisi, vitae volutpat nisl hendrerit sed. Aenean sit amet augue scelerisque, venenatis dui non, elementum urna. Vestibulum dignissim leo sed sapien sollicitudin, non condimentum nibh sagittis. Aliquam a congue orci. Maecenas pellentesque nulla id mi egestas, sit amet convallis magna iaculis. Aliquam tincidunt rutrum sagittis. Nulla imperdiet aliquet velit, at consequat lectus consectetur a. Praesent vitae libero vel arcu volutpat pellentesque molestie a turpis. Vivamus consequat rhoncus rutrum. Donec vitae justo vel ipsum posuere porta vel vitae nisl. In sollicitudin est in enim consectetur posuere. Cras lobortis vel justo sed pharetra. Pellentesque at dui sed tellus iaculis pellentesque eget eget est. Morbi in viverra ligula. Pellentesque sollicitudin libero lorem, id consequat quam placerat consectetur.

Praesent gravida cursus cursus. Nam elit lacus, tincidunt eu sapien eu, feugiat accumsan purus. Aliquam erat volutpat. Praesent nec pellentesque lorem. Cras faucibus tincidunt quam, ac rutrum orci dignissim sed. Donec volutpat venenatis lacus, eu cursus metus luctus sed. Nullam ac malesuada tellus.

Vivamus mattis, ipsum in venenatis facilisis, diam elit facilisis mauris, ut bibendum eros elit in nunc. Duis vitae vestibulum lorem. Nam felis justo, rutrum et hendrerit id, posuere quis odio. Proin in est enim. Sed malesuada purus sit amet tellus ultrices, eget ullamcorper ipsum vulputate. Vestibulum vestibulum nulla vel turpis convallis pharetra. Sed sem quam, accumsan ac augue et, elementum pulvinar orci.

Proin adipiscing neque eget magna adipiscing tincidunt. Etiam sagittis orci eu justo elementum tempor. Nullam sit amet urna velit. Maecenas quis felis velit. Suspendisse convallis condimentum risus, luctus feugiat metus condimentum in. Nam ut dapibus felis. Proin eget quam mattis, facilisis turpis quis, laoreet velit. Morbi non tincidunt libero. Sed vestibulum leo elit, vitae sagittis justo pulvinar sit amet. Proin bibendum felis ut erat laoreet, in euismod turpis blandit. Quisque nec ultrices erat.

Mauris orci erat, malesuada vitae posuere non, placerat vitae dolor. Cras dapibus fringilla nibh. Nulla facilisi. Mauris viverra felis in vestibulum vehicula. Aliquam vestibulum, tellus ac porttitor euismod, neque turpis pulvinar ipsum, non tempor neque magna at arcu. Mauris eu semper diam. Proin vitae blandit sapien. Integer tempus, leo nec auctor laoreet, odio massa adipiscing sem, congue hendrerit est lectus rhoncus mi. Vestibulum volutpat elit dolor, eu feugiat leo hendrerit vitae. Vestibulum quis ornare tellus.

Vestibulum ac luctus ligula, eget eleifend sem. Etiam porttitor elementum metus, quis imperdiet sem sagittis sed. Maecenas mattis arcu eu sagittis eleifend. Praesent venenatis nulla in enim lacinia rutrum. Aenean id lectus non magna scelerisque aliquam eu ut ante. Ut ipsum risus, gravida eget metus non, ornare porttitor lorem. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque suscipit egestas sapien, ut dapibus urna congue sed. Integer a mollis lorem, ac iaculis tortor. Ut elit est, dapibus eu faucibus vitae, condimentum ac lorem. Nam adipiscing, velit vel dictum venenatis, tellus urna pharetra elit, in rutrum metus lacus et sem. Interdum et malesuada fames ac ante ipsum primis in faucibus. Curabitur odio metus, porttitor sed laoreet eu, pharetra at lacus. Duis gravida neque ligula, sed iaculis augue mollis eu. Nam viverra dictum ipsum, non sodales est ultricies in.

Praesent non pharetra nisi. Maecenas vitae nunc consequat, feugiat magna in, lobortis erat. Duis tincidunt tincidunt nunc. Nunc dignissim feugiat ligula faucibus posuere. Maecenas porta consequat varius. Nunc quis mi semper, vulputate elit vitae, rutrum ipsum. Suspendisse quis volutpat ligula. Vestibulum tincidunt justo purus, ac mattis ligula laoreet vel. Sed quis orci nec enim tincidunt faucibus. Nullam nec tincidunt justo. Pellentesque tempor accumsan arcu, ut fringilla urna. Etiam volutpat feugiat ligula, sed mollis tellus tempus quis. Mauris porttitor purus luctus pellentesque aliquam. In nulla sapien, tempor sed aliquam ullamcorper, tempor eget nibh. Nunc id massa ac purus convallis condimentum ac vel ligula.

Fusce molestie elit turpis. Etiam non felis tempus, lobortis libero sed, congue leo. Aliquam non consequat lectus. Aenean urna purus, vestibulum id consequat ut, commodo vitae dui. Morbi id orci interdum, condimentum lectus et, porttitor ipsum. Quisque tristique lectus imperdiet quam pellentesque blandit. Sed purus mi, elementum sed justo eu, sagittis tempor mi. In nec ultrices velit. Integer hendrerit turpis orci, ac viverra tortor dapibus rutrum. Curabitur id ultricies quam, non bibendum sem. Integer ut eros adipiscing, adipiscing augue non, hendrerit lorem. Nunc vehicula, odio ac scelerisque ornare, turpis nisl faucibus libero, lobortis ornare magna arcu sit amet nisl. Vivamus consectetur lacus dui, eu iaculis ante egestas at. In semper, ipsum ac convallis tincidunt, nunc quam aliquam orci, sed feugiat lectus lorem ut quam. Nunc quis rutrum arcu, in interdum orci. Fusce non sapien at magna rutrum molestie.

Nullam adipiscing pretium nibh, consectetur porta leo fringilla vel. Vivamus pharetra, magna eget lobortis euismod, sapien urna convallis orci, in ullamcorper lacus augue sit amet mi. Duis tincidunt molestie elit, vel lacinia augue ultrices vel. Maecenas dui turpis, gravida eu eros a, elementum cursus nisl. Aliquam ultricies, est sit amet blandit mollis, est nisl varius risus, id condimentum nunc lectus id dolor. In facilisis placerat nisl, et sagittis ipsum ultricies in. Maecenas quis auctor arcu. Nunc vitae vehicula purus.

Donec semper sed nibh ultrices ultricies. Vivamus id cursus dui, vel venenatis nunc. Cras tincidunt nisi nec porta placerat. Morbi a ultrices metus. Fusce suscipit nibh dapibus est auctor, eget sagittis nunc eleifend. In tempor libero ultricies sapien tempor imperdiet. Phasellus vel nisi a lectus iaculis tincidunt. Nunc sed volutpat odio, vitae aliquam ipsum. Proin dapibus lorem rhoncus sodales tempus. Fusce ut bibendum enim. Ut elit nulla, vulputate quis tortor id, ultrices consectetur lacus. Quisque a cursus ipsum. Sed vitae risus at tellus bibendum luctus. Ut varius pharetra turpis, id facilisis ligula. Morbi volutpat velit orci, sed venenatis felis bibendum ac. Vestibulum dictum mi adipiscing, pellentesque est et, cursus dui.

Duis mollis volutpat lectus sed convallis. Phasellus ultricies dignissim quam. Nam vehicula eleifend ultricies. Vivamus varius dapibus metus, et condimentum diam sollicitudin quis. Praesent tempor id est et tincidunt. Phasellus quis nisi nec metus tristique facilisis. Quisque luctus sit amet mi non iaculis.

Fusce at venenatis diam, vitae bibendum ante. Mauris scelerisque nulla sit amet dui dictum, vitae sodales felis accumsan. Integer a mauris arcu. Nulla vitae neque sodales, tempor sapien sed, venenatis risus. Aliquam hendrerit elit lobortis facilisis auctor. Aliquam erat volutpat. In auctor purus sit amet leo iaculis sagittis. Donec dictum augue dolor, a ornare ante dapibus eget. Sed tempus non tellus et tempus. Integer feugiat magna quam, quis tincidunt lorem mattis et. Nam sed convallis tortor.

Vestibulum a elementum nulla. Maecenas ultricies augue vitae semper feugiat. Nulla elit nisl, semper vitae faucibus a, imperdiet in dui. Aenean tincidunt facilisis vestibulum. Quisque aliquet ante ac vestibulum tincidunt. Etiam vitae ipsum vel quam pretium suscipit venenatis id massa. Maecenas eleifend purus aliquet est euismod egestas. Ut porttitor eget orci nec pellentesque. Sed quis neque nec mauris lacinia condimentum nec varius metus. Integer vitae tellus id nisl consequat lobortis iaculis sed quam. Praesent ut faucibus tellus, a dapibus dui. Pellentesque ut felis at erat lacinia iaculis nec ac eros. Donec a ipsum dolor. Nulla quis tempor lorem.

Proin ac ultrices lacus. Mauris porttitor nibh tortor, in euismod nunc congue et. Maecenas congue ultricies aliquam. Pellentesque auctor, augue molestie pellentesque scelerisque, libero eros vehicula purus, sed faucibus odio nunc non turpis. Phasellus ipsum arcu, lacinia eget tincidunt ac, porta id nunc. Nunc sed porttitor ligula, at tristique magna. Duis id tincidunt nisi. Donec at felis id turpis eleifend consectetur. Nam nec convallis diam, at adipiscing quam. Etiam tincidunt, nibh ac bibendum gravida, quam diam aliquam neque, ac malesuada sem nisi vulputate est. Cras condimentum iaculis libero, nec fringilla ipsum bibendum et. Vestibulum rhoncus risus et mauris vulputate, ac mollis risus tempor. Aenean eu mi sit amet leo scelerisque venenatis id sit amet urna. Aenean et dapibus lacus, quis fermentum massa. Quisque quis arcu vulputate, pretium metus eget, tristique nisl.

Maecenas id porta nibh, quis consectetur dui. Nullam dapibus pellentesque sodales. Sed lacinia, sem ultricies convallis placerat, nisi ligula sollicitudin sem, placerat ultrices magna nisl non ante. Aliquam tempor fermentum diam sit amet placerat. Vestibulum vitae diam a massa suscipit posuere. Quisque et est commodo, placerat libero eget, dapibus sapien. Fusce sit amet erat sit amet purus venenatis aliquet ut nec nulla. Maecenas blandit posuere lacus eget bibendum. Suspendisse mattis mollis magna a mollis. Cras vitae condimentum tortor. Proin laoreet magna ac venenatis accumsan. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent sit amet lobortis leo. Sed bibendum lorem id nunc imperdiet, at accumsan dui ullamcorper. Curabitur eu blandit mauris, laoreet fermentum risus.

Donec feugiat eros libero. Vivamus tristique mauris ante, ac accumsan est mollis eget. Donec sed leo et risus bibendum cursus. Curabitur imperdiet euismod est, at mollis nulla elementum vitae. Vestibulum tincidunt magna lacus, in ornare sapien rutrum vitae. Nam tempus orci justo, eget feugiat tellus commodo scelerisque. Ut mattis tellus elit, ut tincidunt est malesuada quis. Proin porta ac ante at dictum. Pellentesque sed arcu nisi. Vivamus mattis hendrerit massa a vulputate. Vestibulum commodo blandit ullamcorper. Cras placerat sem vitae tristique pretium. Mauris tempor elementum mauris. Curabitur lacinia gravida erat, nec varius dolor pellentesque sed. Nulla id sapien congue, molestie urna ac, molestie sapien.

Pellentesque at nunc ac turpis faucibus ullamcorper. Morbi leo lorem, ultrices sed vehicula a, iaculis non turpis. Sed posuere ut libero sed tempor. Vivamus elit felis, lobortis nec sollicitudin id, vulputate nec velit. Nam lacus orci, dapibus non ante interdum, aliquet tristique lectus. Sed a congue est, ut varius ligula. Mauris sed libero nulla. Nam feugiat, mi eget feugiat fermentum, arcu libero viverra tellus, sit amet luctus neque dolor a lacus. Ut ornare tortor metus, vitae cursus metus interdum id. Aliquam consectetur nisi ut leo volutpat, in pellentesque risus semper. Proin dolor nisl, auctor vitae aliquam in, venenatis non arcu. Aenean fringilla ligula a massa interdum, in facilisis felis imperdiet. Ut condimentum, risus id faucibus sodales, dui risus bibendum est, ut porttitor tellus turpis eu tortor. Nam at ante dignissim, consequat augue vitae, viverra est.

Duis varius leo vitae dignissim porta. In consectetur mauris libero, nec iaculis enim bibendum non. Nullam non erat ut nunc dapibus tristique. Quisque eu elit mollis, porttitor neque eu, egestas tortor. Aenean accumsan congue tempor. Etiam molestie vel odio ut cursus. Nunc quam lorem, tempor vel tincidunt a, tincidunt sit amet sem. Donec nec volutpat sapien. Praesent feugiat iaculis odio. In cursus turpis quis ante ultrices, lobortis placerat ante dictum. Fusce vel diam elementum, tempus ligula nec, mollis libero. Praesent at eros nulla.

Etiam cursus sodales auctor. Proin tincidunt facilisis porttitor. Praesent feugiat, urna at bibendum lobortis, lorem nibh ultricies libero, aliquam tempor purus felis ac enim. Donec iaculis sollicitudin accumsan. Aliquam ut fermentum lacus. Maecenas non purus metus. Lorem ipsum dolor sit amet, consectetur adipiscing elit.

Ut pulvinar rhoncus hendrerit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In imperdiet, nisl ut dictum rhoncus, nulla elit consequat turpis, a elementum ipsum lacus in nunc. Pellentesque quis magna vitae odio auctor bibendum sit amet id tellus. Aliquam adipiscing, ipsum quis scelerisque commodo, libero turpis sollicitudin sem, et condimentum enim libero adipiscing lorem. Nunc scelerisque massa nisl, ac dictum augue molestie non. Integer placerat in eros eget tincidunt. Maecenas pellentesque elementum porta. Cras varius metus vel ante condimentum interdum. Sed id sapien nec ante vehicula sagittis. Suspendisse posuere justo in enim lobortis, vitae rutrum quam iaculis.

Sed ut nunc et neque sollicitudin tristique vitae et sapien. Praesent nunc felis, scelerisque quis mi eget, vulputate mollis lectus. Sed tempus eleifend mauris, at tempus ipsum fringilla nec. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. In hac habitasse platea dictumst. Ut in eros sapien. Suspendisse scelerisque velit ante, ac malesuada mauris vehicula eu. Cras scelerisque luctus mauris, sed aliquam elit elementum feugiat. Curabitur vitae elit ac enim varius viverra. Integer rhoncus, magna nec ultrices ornare, ligula quam sodales dui, semper tincidunt nibh tortor at massa. Curabitur in molestie leo. Aliquam id massa accumsan, egestas magna vitae, sodales est.

Curabitur pulvinar auctor facilisis. Cras porta consectetur massa, sed accumsan ligula molestie a. Donec luctus ante vitae auctor posuere. Sed dapibus tincidunt interdum. Vivamus consectetur, enim eu ornare facilisis, neque neque posuere nunc, eget molestie nisl elit quis turpis. Aliquam aliquet erat id fringilla ultricies. Quisque faucibus sapien at feugiat bibendum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed fringilla nunc in orci luctus, sit amet vulputate justo commodo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In purus tellus, dictum eu eros in, laoreet faucibus ipsum. Proin ullamcorper, tortor et tristique ultricies, lectus nisi ullamcorper enim, id rutrum magna lacus eget velit. Curabitur scelerisque quis elit et condimentum. Praesent volutpat lobortis nisi in iaculis. Nam suscipit eu felis dictum ultrices.

Sed pellentesque sapien quis felis dignissim rutrum aliquam at lorem. Nullam nisi velit, varius id arcu vitae, viverra elementum odio. Maecenas faucibus dolor metus, non tristique velit ultricies a. Mauris ultricies et eros vitae convallis. Nunc ac sapien nec sem facilisis pharetra. Mauris at justo vel eros hendrerit porttitor. Ut in interdum augue. Phasellus eleifend sodales malesuada.

Nullam ut lobortis nunc, eu pellentesque neque. Quisque aliquam pellentesque lorem, vitae mollis dui mattis quis. Nam ante ipsum, convallis et condimentum non, auctor eu urna. Vestibulum eget mauris velit. Etiam eu tincidunt eros, vel molestie metus. Suspendisse potenti. Morbi posuere mauris ac augue laoreet, id rutrum dolor tincidunt. Praesent felis leo, lacinia eget vehicula ut, condimentum at sapien. Ut venenatis lacus diam, sed cursus lorem eleifend ut.

Cras convallis nisl id nisi euismod volutpat. Nam sed lectus id sem imperdiet consectetur. Etiam sit amet diam semper, tempor dolor sed, faucibus quam. Praesent non pulvinar risus. Nullam ac lobortis lacus. Curabitur suscipit diam sem, faucibus facilisis est pretium eu. Donec vitae magna nulla.

Ut mollis, purus a mollis cursus, orci quam eleifend eros, fringilla iaculis ante justo et leo. Donec tempus facilisis odio, vel ornare ipsum suscipit cursus. Pellentesque sagittis justo non tristique pharetra. Ut sem est, adipiscing vitae volutpat et, pulvinar eu urna. In gravida sapien sit amet libero ultrices hendrerit. Sed lacus nunc, aliquet nec semper vitae, consequat eu ante. In at quam bibendum augue tristique suscipit. Vivamus iaculis turpis at libero posuere, et pellentesque odio malesuada. Aenean iaculis lacus justo, non vulputate nisl lacinia vitae. Morbi ipsum arcu, facilisis sed dictum vitae, mattis et nunc.

Proin viverra luctus sapien tempor consectetur. Cras commodo erat sit amet gravida interdum. Vivamus mattis mollis tellus faucibus tristique. Sed aliquam, enim eu lacinia volutpat, urna sem pellentesque lectus, id dictum lacus nunc quis justo. Fusce eros dolor, pharetra quis eros at, sollicitudin varius massa. Etiam tincidunt, risus quis convallis hendrerit, nisl metus hendrerit diam, ut tincidunt justo eros quis felis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris mattis tellus ut dui venenatis lobortis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla malesuada quis augue tristique condimentum. Integer id imperdiet nisi. Aliquam rhoncus dui quis gravida tempor. Sed gravida nec risus sit amet aliquet. Maecenas quis pellentesque magna, vitae posuere orci.

Nunc ac sem massa. Aliquam vel nunc et orci porttitor tristique. Donec id lectus euismod, consectetur sapien id, rutrum justo. Aenean sed fringilla nibh. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vivamus eget nibh mauris. Nulla interdum odio sed tortor tristique, non vestibulum justo vulputate. Sed malesuada dui nec ante consectetur, vel auctor felis volutpat. Donec eu ipsum egestas, pharetra nulla a, aliquam nulla. Sed venenatis felis urna, eu pellentesque urna sagittis eu. Aenean varius condimentum odio, at laoreet elit lobortis sed. Donec mattis porttitor rhoncus. Integer odio augue, congue porta placerat id, posuere in ligula. Donec volutpat dignissim velit quis dictum. Donec hendrerit accumsan congue.

Suspendisse imperdiet quam non leo suscipit, vel volutpat sapien euismod. Curabitur dui elit, scelerisque eget neque quis, vehicula lacinia elit. Duis vehicula ac justo at commodo. Donec leo nisi, aliquet id iaculis ac, consequat et elit. Nam at scelerisque ligula, ultrices facilisis tortor. Etiam arcu justo, blandit a lacinia eget, placerat nec sapien. Nunc elementum pulvinar egestas. Mauris aliquet arcu et suscipit mattis. Sed ligula libero, adipiscing a convallis congue, auctor nec nisi. Nulla non lacus vel turpis dictum tempus. In auctor purus id suscipit hendrerit. Cras accumsan eleifend sem vitae pellentesque. Proin elit purus, commodo id posuere ut, tempor ut eros. Curabitur sed orci ac massa posuere mattis a et nibh. Integer vulputate facilisis semper. Praesent id volutpat ipsum.

Nulla bibendum dictum nulla vitae cursus. Praesent massa tellus, commodo in mauris eu, aliquet porta lorem. Aenean in dolor a odio egestas mollis nec nec neque. Interdum et malesuada fames ac ante ipsum primis in faucibus. In pellentesque urna vitae tortor commodo malesuada. Aliquam erat volutpat. Ut sit amet auctor purus. Donec elementum mi quis neque pulvinar dapibus. Suspendisse aliquam tempus velit, hendrerit feugiat dui eleifend a. Ut volutpat vel nisi id elementum. Aliquam cursus risus eget lectus adipiscing, ut varius massa aliquet. Morbi scelerisque, lectus ac mollis ornare, lacus diam tempus lectus, eu vestibulum neque nisl sed dui. Maecenas quam nisl, molestie vel orci at, semper blandit diam. Nunc tristique, nulla eu tempus consectetur, nisi lorem consequat enim, eu pretium nunc felis ac neque. Proin in blandit leo, at vulputate enim.

Sed dictum accumsan nisi eu euismod. Pellentesque molestie magna a tellus sollicitudin interdum. Nam et nibh ut libero laoreet accumsan ut in turpis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam mauris nisi, facilisis at mattis quis, molestie ut nisi. Suspendisse vehicula tortor vel suscipit hendrerit. Vivamus varius nec urna et ultricies. Aenean euismod ipsum quis viverra malesuada. Nam augue metus, semper vel est id, volutpat ultrices elit. Maecenas ultricies venenatis metus, et posuere erat iaculis sed. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;

Nullam quis malesuada sapien. Vivamus scelerisque tempus turpis ac aliquet. Pellentesque condimentum metus nec dolor tincidunt placerat quis at ante. Cras sed vestibulum justo. Proin turpis elit, condimentum mattis neque vestibulum, condimentum rutrum quam. Cras est elit, semper ut lacus sed, aliquam tempor diam. Aliquam quis vulputate elit, non adipiscing nisl. Morbi at elit tristique, feugiat massa vitae, auctor augue. Pellentesque et purus nec mauris rutrum ullamcorper.

Proin egestas odio ut tincidunt posuere. Sed ac euismod massa, a pellentesque nisl. Nunc ultrices et augue sit amet imperdiet. Aliquam in metus facilisis, euismod nisi nec, venenatis felis. Donec porta augue a diam imperdiet cursus. Nunc est odio, commodo et consequat ut, tempor quis felis. Aliquam erat volutpat. Vivamus tristique dui ligula.

Interdum et malesuada fames ac ante ipsum primis in faucibus. Mauris consequat enim sit amet ante feugiat scelerisque. Praesent tristique nisi nec turpis lobortis, eu ultricies lectus semper. Proin rhoncus libero sit amet volutpat volutpat. Nunc ultrices consequat elit, in vestibulum est dignissim eget. Fusce scelerisque lectus non dui suscipit condimentum. Vivamus enim lacus, sagittis quis gravida a, aliquam in odio. Curabitur diam libero, scelerisque vitae libero a, accumsan iaculis diam.

Duis scelerisque elementum lectus, id hendrerit sapien elementum ut. Etiam risus sapien, varius a volutpat et, feugiat non tellus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam commodo odio tempus lorem imperdiet malesuada. Vivamus lacinia mi risus, id eleifend neque consectetur ac. Donec dictum felis in lacinia tempor. In aliquet vitae quam in facilisis. Aliquam non mi sed augue dictum auctor vel interdum turpis. Nulla non cursus enim. Quisque porta elementum elit, id ultricies mauris euismod at. Suspendisse in sagittis lorem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus est neque, faucibus in consectetur id, commodo non lorem. Maecenas tristique, tellus id facilisis gravida, urna nisl pulvinar libero, sit amet interdum tortor nunc eu ante. Integer id nulla in mauris placerat lacinia et at eros.

Praesent luctus massa arcu, ultrices rhoncus eros ullamcorper quis. Mauris non nulla id dolor tristique vulputate. In ultricies faucibus sollicitudin. Donec eu turpis eu orci faucibus fermentum sodales non nisl. Morbi nec turpis volutpat, auctor lorem ac, pretium est. Nullam pellentesque dignissim ultrices. Fusce faucibus turpis vel est adipiscing tempus. Proin scelerisque ligula et orci porta vehicula. Etiam sit amet tincidunt enim. Nunc tempor justo libero, ornare rutrum dolor imperdiet id. Nullam faucibus laoreet mi, nec ullamcorper lorem placerat non. Nunc mollis neque ac volutpat luctus.

Pellentesque lacinia justo eget blandit consectetur. Quisque ipsum lacus, porta vitae feugiat nec, porta quis metus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Sed molestie dignissim metus, et tempus metus tincidunt vitae. Sed venenatis consequat luctus. Sed eget sem a est dignissim vulputate quis ac odio. Phasellus ultrices urna non ligula mattis congue. Integer hendrerit, nisi eget dictum scelerisque, dolor erat auctor arcu, eget volutpat sem massa id diam. Sed a nisi blandit erat rutrum euismod vestibulum sed leo. Aenean sit amet nisi eget sem placerat blandit. Fusce quis lobortis nisl, sed imperdiet nulla.

Nulla leo ante, suscipit in bibendum in, condimentum non tellus. Cras nec porttitor metus, non facilisis orci. Curabitur dignissim scelerisque velit. Nulla facilisi. Etiam mattis velit nec elit molestie, sed auctor est fringilla. Etiam a blandit nisi, venenatis ullamcorper lectus. Donec accumsan nisi nec dui dictum, viverra consequat sem vulputate. Cras id tempor quam, non ornare felis. Proin fringilla erat at adipiscing cursus. Pellentesque semper consequat consequat. Vivamus et odio nec sem mattis posuere. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam sollicitudin aliquam iaculis. Phasellus consequat sapien tempor, aliquet massa vitae, sagittis diam. Aliquam dapibus ac velit id dapibus. Fusce eget sem orci.".Split(' ');
            trie.InsertRange(words);
            bool actual = trie.Contains("urna");

            Assert.AreEqual(true, actual);
        }

        #endregion

        #region PrefixSearchTests
        [TestMethod]
        public void InsertWordsAndSearchForThem()
        {
            Trie trie = new Trie();
            string word = "Gosho";
            trie.Insert(word);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            ICollection<string> results = trie.Search(word);
            bool actual = results.Contains(word) && results.Contains(word2);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertRangeManyWordsAndCheckIfContainsOne()
        {
            Trie trie = new Trie();
            string[] words = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vitae accumsan libero, vitae cursus orci. Aliquam interdum, velit non commodo rhoncus, elit eros pulvinar magna, in aliquam ipsum tellus semper sem.".Split(' ');
            trie.InsertRange(words);
            bool actual = trie.Contains("eros");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchFor3OfThem()
        {
            Trie trie = new Trie();
            string word = "Gosho";
            trie.Insert(word);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            ICollection<string> results = trie.Search(word);
            bool actual = results.Contains(word) && results.Contains(word2) && results.Contains(word3);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchFor4OfThem()
        {
            Trie trie = new Trie();
            string word = "Gosho";
            trie.Insert(word);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);
            ICollection<string> results = trie.Search(word);
            bool actual = results.Contains(word) && results.Contains(word2) && results.Contains(word3)
                && results.Contains(word4);

            Assert.AreEqual(true, actual);
        }

        

        #endregion

        #region SubstringSearchTests
        [TestMethod]
        public void InsertWordsAndSearchForThemBySubstring()
        {
            Trie trie = new Trie();
            string word = "P";
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);

            ICollection<string> results = trie.Search(word, SearchType.Contains);
            bool actual = results.Contains(word2) && results.Contains(word3)
                && results.Contains(word4);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchForThemBySubstring2()
        {
            Trie trie = new Trie();
            string word = "P";
            string word1 = "IskamPomo";
            trie.Insert(word1);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);

            ICollection<string> results = trie.Search(word, SearchType.Contains);
            bool actual = results.Contains(word1) && results.Contains(word2) && results.Contains(word3)
                && results.Contains(word4);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchForThemBySubstring3()
        {
            Trie trie = new Trie();
            string word = "Pe";
            string word01 = "YesPesho";
            trie.Insert(word01);
            string word1 = "IskamPomo";
            trie.Insert(word1);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);

            ICollection<string> results = trie.Search(word, SearchType.Contains);
            bool actual = results.Contains(word01) && results.Contains(word2) && results.Contains(word3)
                && results.Contains(word4);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchForThemBySubstring4()
        {
            Trie trie = new Trie();
            string word = "io";
            string word01 = "YesPesho";
            trie.Insert(word01);
            string word1 = "IskamPomo";
            trie.Insert(word1);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);

            ICollection<string> results = trie.Search(word, SearchType.Contains);
            bool actual = results.Contains(word3);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InsertWordsAndSearchForThemBySubstring5()
        {
            Trie trie = new Trie();
            string word = "Bor";
            string word01 = "YesPesho";
            trie.Insert(word01);
            string word1 = "IskamPomo";
            trie.Insert(word1);
            string word2 = "GoshoPesho";
            trie.Insert(word2);
            string word3 = "GoshoPeshoVanio";
            trie.Insert(word3);
            string word4 = "GoshoPeshoBore";
            trie.Insert(word4);

            ICollection<string> results = trie.Search(word, SearchType.Contains);
            bool actual = results.Contains(word4);

            Assert.AreEqual(true, actual);
        }

        #endregion
    }
}
