   M S B A M L   `   `   `  ����O  KDietHolder2ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DietHolder2ClientWPF.ViewModelsDietHolder2ClientWPF.ViewModels  5      | xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5      7    1DietHolder2ClientWPF.Views.ProductsCompariserView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      D
viewModels-clr-namespace:DietHolder2ClientWPF.ViewModels     5      �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      $	��350��5      $	��400��6     � DataContext  5      A   ;DietHolder2ClientWPF.ViewModels.ProductsCompariserViewModel  5	       � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  LabelValuesStyle  ComboboxStyle��%�  &	        &	 �     &	 �    �� 5   
   " ��6#   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,0,5,0q�6'   �� 5       � ��$ 14(�6)   �� 5       � ��$ DK Longreach)�6+   �� 5       � ��
 �""��6,   5      �� 5   
   " ��6)   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ New Athletic M54)�6+   �� 5       � ��
 �""��6,   �� 5       � ��$ Center=�65   5      �� 5   
   " ��6&   .�5      ��  � ��$ 30��6'   �� 5       � ��$	 180��6&   �� 5       � ��$ 14(�6)   �� 5       � ��$ DK Longreach)�6+   �� 5       � ��
 �<��6,   5       5!      .��5"      �  � ColumnDefinitions 5#   
   �� 5$      �� 5%       � RowDefinitions 5'   
   �� 5(      �� 5)      �� 5*      $	��120 �6   �� 5+      .+�5.   
   �� $��0��6   $��0��6!   $��2��61    J� Opacity$
 0.35Q�6E   ��5/      �� 50       �� Color$ 	LightBlue��6"   52      � 53   
   $��0��6   $��0��6   $��2��6,    54      �� 55      �� 56       58      �� 59      �� 5:      .+�5<      �� $��0��6   $��0��6!   $��2��61   $��15(�5=      $6��0Please choose products what You want to compare.��5>      #��[ 5?      �� 5@      $��1��6   $��0��6$   #��[ 64   ��5A      �� 	 �� Mode$	 OneTime=�
 �� Path$
 ProductsNames� �� SelectedValue 5B      �� $	 OneWayToSource=� �� NotifyOnTargetUpdated . $
 FirstUserInputProductName��� 5D      $��1��6   $��1��6$   #��[ 64   ��5E      �� $	 OneTime=�$
 ProductsNames� 5F      �� $	 OneWayToSource=� . $ 
 SecondUserInputProductName�5H      �� 5I   
   $��1��6   $��0��6!   $��2��61   $
 0.35Q�6E   ��5J      �� 5K      $ 	MintCream��6"   5M      �� 5N   
   $��1��6   $��0��6   $	��180��6-   $��60��69   $��10q�5O      ��5P      �� *FirstProductImageSourcePath+�� 5Q   
   $��1��6   $��1��6   $	��180��6-   $��60��69   $��10q�5R      ��5S      �� *SecondProductImageSourcePath+�� 5U   
   $��2��6   $��0��6!   $��2��61   $
 0.35Q�6E   ��5V      �� 5W      $ CornflowerBlue��6"   5Y      � 5[   
   $��2��6   $��0��6   $	��200��6,    5\      �� 5]      �� 5^      �� 5_       5a      �� 5b      �� 5c      �� 5d      $��30 �6    �� 5e      $��22 �6    .+�5h      �� $��Center=�6   $��0��61   $��0��6>   $��3��6N   $��Product details��5i      #��[  6.   �� 5j      $��16(�6   $��1��6"   $��0��6/   $��3��6?   #��[ 5l      ��5k      �� $	 OneWay=�$&
  SelectedFirstProduct.ProductName�5l      �� 5m      $��2��6   $��0��6!   $	��Top=�61   #��[ 5o      ��5n      �� $	 OneWay=�$,
 &SelectedFirstProduct.ProductCarboValue�5o      �� 5p      $��2��6   $��1��6!   $	��Top=�61   #��[ 5r      ��5q      �� $	 OneWay=�$.
 (SelectedFirstProduct.ProductProteinValue�5r      �� 5s      $��2��6   $��2��6!   $	��Top=�61   #��[ 5u      ��5t      �� $	 OneWay=�$*
 $SelectedFirstProduct.ProductFatValue�5u      �� 5v      $��3��6   $��8(�6!   $��0��6.   $��Bottom=�6>   $��Carbos��5w      #��[ 5x      �� 5y      $��3��6   $��8(�6!   $��1��6.   $��Bottom=�6>   $��Proteins��5z      #��[ 5{      �� 5|      $��3��6   $��8(�6!   $��2��6.   $��Bottom=�6>   $
��Fats��5}      #��[ 5~      5      � 5�   
   $��2��6   $��1��6   $	��200��6,    5�      �� 5�      �� 5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      $��30 �6    �� 5�      $��22 �6    .+�5�      �� $��Center=�6   $��0��61   $��3��6>   $��Product details��5�      #��[  62   �� 5�      $��16(�6   $��1��6"   $��0��6/   $��3��6?   #��[ 5�      ��5�      �� $	 OneWay=�$'
 !SelectedSecondProduct.ProductName�5�      �� 5�      $��2��6   $��0��6!   $	��Top=�61   #��[ 5�      ��5�      �� $	 OneWay=�$-
 'SelectedSecondProduct.ProductCarboValue�5�      �� 5�      $��2��6   $��1��6!   $	��Top=�61   #��[ 5�      ��5�      �� $	 OneWay=�$/
 )SelectedSecondProduct.ProductProteinValue�5�      �� 5�      $��2��6   $��2��6!   $	��Top=�61   #��[ 5�      ��5�      �� $	 OneWay=�$+
 %SelectedSecondProduct.ProductFatValue�5�      �� 5�      $��3��6   $��8(�6!   $��0��6.   $��Bottom=�6>   $��Carbos��5�      #��[ 5�      �� 5�      $��3��6   $��8(�6!   $��1��6.   $��Bottom=�6>   $��Proteins��5�      #��[ 5�      �� 5�      $��3��6   $��8(�6!   $��2��6.   $��Bottom=�6>   $
��Fats��5�      #��[ 5�      5�      � 5�   
   $��3��6   $��0��6   $��2��6'    5�      �� 5�      �� 5�      �� 5�      5�      5�      5�      