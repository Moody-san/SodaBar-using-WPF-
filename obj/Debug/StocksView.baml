   M S B A M L   `   `   `  ????b  ^Syncfusion.SfChart.WPF, Version=19.1460.0.63, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts  5      I ESodaBarProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SodaBarProjectSodaBarProject 5         SodaBarProject.StocksView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5      .localclr-namespace:SodaBarProject     5        ? 	Resources  5
       SodaBarProject.ViewModel 	  ViewM??%   &	          5   
   6   5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??240 ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??10 ?6   ?? 5      $??* ?6   .+?5   
   ? .+?5      '   !Syncfusion.UI.Xaml.Charts.SfChart   ? DataContext# [  6   )   #Syncfusion.UI.Xaml.Charts.ChartBase   Header$ SodaPopularity??6A   
???????   PrimaryAxis 5      ,   &Syncfusion.UI.Xaml.Charts.CategoryAxis  5         SecondaryAxis 5      -   'Syncfusion.UI.Xaml.Charts.NumericalAxis  5         Legend 5       +   %Syncfusion.UI.Xaml.Charts.ChartLegend  5!         Series. 5#      )   #Syncfusion.UI.Xaml.Charts.PieSeries  /   )Syncfusion.UI.Xaml.Charts.ChartSeriesBase	   XBindingPath$
	 Soda??6C   6	   0Syncfusion.UI.Xaml.Charts.AccumulationSeriesBase
 	  YBindingPath$
 SodaQ??6W      Palette$ Elite=?6l      ShowTooltip .    ItemsSource 6"   ?? *
SodaData+5$      5%      5&      ?? 5'   
   $??1??6   $??0??6!   $??3??61   
???????$??5q?6Y   6o   ? 5(   
   $??2??6   $??0??6   .+?5)        # [  6   $ SyrupPopularity??6A   
??????? 5*        5+       5-        5.       50        51      . 53        $	 Syrup??6D   $
 SyrupQ??6Y   $ Elite=?6p    .  6"   ?? *	SyrupData+54      55      56      ? 57   
   $??1??6   $??0??6   .+?58      ??  ?? CornerRadius$ 10??6   $??5q?6'   
???   ?$	??150??6O   $	??150??6\   ._?59      ?? 
???????
???   ?$??15(?6B   $
??Bold"?6P    ?? TextAlignment$ Center=?6b   $??WrapWithOverflow=?6y   ecThe PieChart at Left Shows how popular each soda is based on the quantity of the soda sold all time6?   5:      5;      ? 5<   
   $??1??6   $??2??6   .+?5=      ?? $ 10??6   $??5q?6'   
???   ?$	??150??6O   $	??150??6\   ._?5>      ?? 
???   ?
???????$??15(?6F   $
??Bold"?6T   $ Center=?6f   $??WrapWithOverflow=?6}   geThe PieChart at Left Shows how popular each syrup is based on the quantity of the syrup sold all time6  5?      5@      ?? 5A   
   $??2??6   $??0??6%   .+?5B      ?? 
???????$??Center=?6'   $??14(?6D   .??6R   Update Soda Stock6e   ?? 5C      
???   ?$??3q?6)   $ 4??6=   $??17q?6N   ._?5D      ?? -   5        $??	SodaCombo??5D   5   5E      5F      ?? 5G      
???????$??Center=?6'   $??14(?6D   $??0,0,2,0q?6R   .??6c   Insert New Stock Value6{   ?? 5H      $??17q?6   $??80??6!   $??25??6,   $ 3??68   $??3q?6I   
???   ?._?5I      ?? -   5         ??Name$ Stocktxt??5I   e   
???   ?
??????? ?? TextAlignment$ Center=?6@    ?? 	MaxLength$ 2??6W   6y   5J      ?? 5K      
???   ?$??3q?6)   $ 4??6=   $	??110??6N   ._?5L      ?? -   5         ??Name$ 	SodaStock??5L   t   $	??110??6   $??30??6%   
???   ?
???????$??Center=?6W   .??6?   	CONFIRM5N      5O      5P      ?? 5Q   
   $??2??6   $??2??6%   .+?5R      ?? 
???????$??Center=?6'   $??14(?6D   .??6R   Update Syrup Stock6f   ?? 5S      
???   ?$??3q?6)   $ 4??6=   $??17q?6N   ._?5T      ?? -   5        $??
SyrupCombo??5T   7   5U      5V      ?? 5W      
???????$??Center=?6'   $??14(?6D   $??0,0,2,0q?6R   .??6c   Insert New Stock Value6{   ?? 5X      $??17q?6   $??80??6!   $??25??6,   $ 3??68   $??3q?6I   
???   ?._?5Y      ?? -   5        $ 	Stocktxt2??5Y   e   
???   ?
???????$ Center=?6@   $ 2??6W   6z   5Z      ?? 5[      
???   ?$??3q?6)   $ 4??6=   $	??110??6N   ._?5\      ?? -   5        $ 
SyrupStock??5\   t   $	??110??6   $??30??6%   
???   ?
???????$??Center=?6W   .??6?   	CONFIRM5^      5_      5`      5a      5b      