   M S B A M L   `   `   `  ����O  KDietHolder2ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DietHolder2ClientWPF.ViewModelsDietHolder2ClientWPF.ViewModels  5      G(clr-namespace:DietHolder2ClientWPF.ViewsDietHolder2ClientWPF.Views  5      5    /DietHolder2ClientWPF.Views.StatisticsCornerView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      D
viewModels-clr-namespace:DietHolder2ClientWPF.ViewModels     5      :views(clr-namespace:DietHolder2ClientWPF.Views     5      $	��350��5	      $	��400��6     � DataContext  5      ?   9DietHolder2ClientWPF.ViewModels.StatisticsCornerViewModel  5       � 	Resources 5       �� DataTypeA   ;DietHolder2ClientWPF.ViewModels.ProductsCompariserViewModel7   1DietHolder2ClientWPF.Views.ProductsCompariserView   ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions �� TextAlignment	 �� Triggers
 P� Property P� Value��%�  (��       5   8   *, +)&	  X     �� 6
   DietStatisticsViewModel��"  68   .R�5          6+   �� 5      �� 5   
   " ��6$   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � $	��150��6   $	��150��6,   
����� �$��10q�5       5      �� 5   "   �� 5   "   $	��100 �60   �� 5   "   .+�5      �� $��1��6(   
���""��$��20(�5!   (   $��DK Longreach)�66   $��Center=�5"   (   #��z��5#   (   $ Center=�5$   (   $
��Wrap=�5%   (   5&      5'      5)      	 5*      P� 5+      
 �@J�IsMouseOver . . �5,      ��  �@J�Opacity$ 1Q�60   5-      P� 5.      
 �@J�IsMouseOver .  . �5/      ��  �@J�Opacity$	 0.7Q�60   50      52      53      .��57      � 
������  58   
   �� 59      �� 5:       � ColumnDefinitions 5<   
   �� 5=      �� 5>      .+�5A   
   �� $��0��6   $��0��6   $��Products compariser��6.   #��[  5C      ��5B      �� *ShowProductsCompariserCommand+5C      �� 5D   
   $��0��6   $��1��6   $��Your eaten macros graph��6.   #��[  5F      ��5E      �� *ShowProductsCompariserCommand+5F      �� 5G   
   $��1��6   $��0��6   $��Products statistics��6.   #��[  5I      ��5H      �� *ShowProductsStatisticsCommand+5I      �� 5J   
   $��1��6   $��1��6   $��I cos jeszcze��6.   #��[  5L      ��5K      �� *ShowProductsCompariserCommand+5L      5M      5N      