   M S B A M L   `   `   `  ????I  ESodaBarProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SodaBarProjectSodaBarProject  5   	       SodaBarProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SodaBarProject     5   	     ? Title$  SODA BAR??5   	   $	??480??6   $	??800??6'    ? 
ResizeMode$ NoResize=?63      Icon ? Icon# [  6I   ??5	      ?? 5
   
     bg ?? ImageSource# [ 6    j? Stretch$
 None=?67   6H   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??150 ?6   ?? 5      $	??650 ?6   .+?5   
   ?? $??0??6   
???????.+?5      ?? $??80??6   $??0,0,0,10q?6!   ._?5      A? ??5      ?? 5      $ UniformToFill=?6%     Soda# [ 6=   5      5      ?? 5      $??80??6   $??3q?6!    ?? CornerRadius$ 10??65   
???   ?$??1,0,1,1q?6[   ._?5      ?? -   5        $
??Menu??5      
???  ??
???????$??25(?6f   $
??Bold"?6t   6?   5      ?? 5      $??80??6   $??3q?6!   $ 10??65   
???   ?$??1,9,1,1q?6[   ._?5      ?? -   5        $??STOCKS??5      
???  ??
???????$??25(?6j   $
??Bold"?6x   6?   5      ?? 5      $??80??6   $??3q?6!   $ 10??65   
???   ?$??1,9,1,1q?6[   ._?5       ?? -   5        $??SETTINGS??5       
???  ??
???????$??25(?6n   $
??Bold"?6|   6?   5!      ?? 5"      $??60??6   $??60??6!   $??1,9,1,1q?6,   $ 8,8,8,8??6=   
???   ?$??3q?6h   ._?5#      ?? -   5        .??5$      ??  
 logout#??[ 6   5%      5&      5'      ? 5(   
   $??1??6   .+?5)         SodaBarProject.MenuView  -   5          Name$ MainMenu??5)      61      SodaBarProject.StocksView  5*      -   5          Name$ Stocks??5*   6   $y?	Collapsed=?6   6H   !   SodaBarProject.SettingsView  5+      -   5        	  Name$	 Settings??5+   8   $y?	Collapsed=?6!   6L   5,      5-      5.      