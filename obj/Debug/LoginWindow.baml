   M S B A M L   `   `   `  ????I  ESodaBarProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SodaBarProjectSodaBarProject  5   	        SodaBarProject.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SodaBarProject     5   	     ? Title$  SodaBarLogin??5   	   $	??450??6   $	??800??6+    ? 
ResizeMode$ NoResize=?67      Icon ? Icon# [  6M   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??500 ?6   6-   ?? 5      6!   .+?5   
   ?? $??1??6   $??20q?6%   .+?5      A? $	??100??6   $	??100??6"   $??Center=?6/   ??5      ?? 5       j? Stretch$ UniformToFill=?6!     mky ?? ImageSource# [ 69   5      ?? 5      $??0,30,0,0q?6   $??Center=?6*   ?? 6H   .?6M   Admin is that you?6a   6h   ?? 5      $
??Bold"?6   .??6&   
Username60   ?? 5      $??50??6   
???   ?$??2q?65    ?? CornerRadius$ 4??6I   ._?5      ?  5      ?? 5      $??50 ?6+   ?? 5      .+?5      ?? $??0??6    ??5      ?? 5      $ Uniform=?6)     un# [ 6;   5       ?? 5!      -   5         ??Name$ txtbox??5!      $??0q?6.   
???   ?$??1??6U   $??Center=?6e   5"      5#      ?? 5$      $
??Bold"?6   .??6'   
Password61   ?? 5%      $??50??6   
???   ?$??2q?65   $ 4??6I   ._?5&      ?  5'      ?? 5(      $??50 ?6+   ?? 5)      .+?5+      ?? $??0??6    ??5,      ?? 5-      $ Uniform=?6)     lk# [ 6;   5/      G? 50      -   5         G?Name$ passwordbox??50   "   $??0q?67   
???   ?$??1??6^   $??Center=?6n   51      52      ?? 53      $??15q?6   $??40??6"   
???   ?$??2q?6B   $ 4??6V   $	??100??6g   ._?54      ?? -   5        ???#fdc106$
??Bold"?54   .   .??6[   Login6b   55      56      ?? 57   
   $??UniformToFill=?6    
 image1#??[ 6(   	 ? Triggers	 58      :? 59      
 :? RoutedEvent$
 Loaded??6   .[?5:      ?? .??5;      ?? .??5<      W?  ?? TargetProperty$ Opacity?5=   !    g? 
SpeedRatio$ .5Q?5>   !    W? From$ .5X?5?   !   	 W? To$ 1X?5@   !    g? RepeatBehavior$ Forever??5A   !   W? 5B      $ Opacity?5C   !   $ .5Q?5D   !   $ 1X?5E   !   $ .5X?5F   !   $ Forever??5G   !   T? 5H      $ Source?5I   !    g? Duration$ 0:0:6D?5J   !   $ Forever??62   ..?5K   "   i?  
 image3 R? Value# [ 69    R? KeyTime$ 0:0:2??6Y   i? 5L   "    
 image2# [ 69   $ 0:0:4??6Y   5M      5N      5O      5P      5R      5S      5T      