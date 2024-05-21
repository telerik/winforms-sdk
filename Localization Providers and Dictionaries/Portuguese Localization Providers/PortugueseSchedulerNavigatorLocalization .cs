using Telerik.WinControls.UI;

public class PortugueseSchedulerNavigatorLocalization : SchedulerNavigatorLocalizationProvider 
{ 
 public override string GetLocalizedString(string id) 
 { 
  switch (id) 
  { 
  case SchedulerNavigatorStringId.DayViewButtonCaption: 
  { 
   return "Vista Diária"; 
  } 
  case SchedulerNavigatorStringId.WeekViewButtonCaption: 
  { 
   return "Vista Semanal"; 
  } 
  case SchedulerNavigatorStringId.MonthViewButtonCaption: 
  { 
  return "Vista Mensal"; 
  } 
  case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption: 
  { 
   return "Mostrar Fim-de-Semana"; 
  } 
 } 
 return string.Empty; 
 } 
} 