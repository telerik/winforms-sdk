using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _995295_GridGermanSymbols
{
    class
CustomSchedulerNavigatorLocalizationProvider
:
SchedulerNavigatorLocalizationProvider

    {


        public
        override
        string
        GetLocalizedString(
        string
        id)

        {


            switch
            (id)

            {


                case
                SchedulerNavigatorStringId
                .DayViewButtonCaption:

                    {


                        return
                        "Gün Görünümü"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .WeekViewButtonCaption:

                    {


                        return
                        "Hafta Görünümü"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .MonthViewButtonCaption:

                    {


                        return
                        "Ay Görünümü"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .TimelineViewButtonCaption:

                    {


                        return
                        "Zaman Görünümü"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .ShowWeekendCheckboxCaption:

                    {


                        return
                        "Haftasonunu Göster"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .TodayButtonCaptionToday:

                    {


                        return
                        "Bugün"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .TodayButtonCaptionThisWeek:

                    {


                        return
                        "Bu Hafta"
                        ;

                    }


                case
                SchedulerNavigatorStringId
                .TodayButtonCaptionThisMonth:

                    {


                        return
                        "Bu Ay"
                        ;

                    }

            }




            return
            String
            .Empty;

        }

    }

}
}
