   M S B A M L   `   `   `  ����Q  MWPFTextBoxAutoComplete, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null_Dclr-namespace:WPFTextBoxAutoComplete;assembly=WPFTextBoxAutoCompleteWPFTextBoxAutoComplete  5      | xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5      O KDietHolder2ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:DietHolder2ClientWPF.Models.MediatorPattern+DietHolder2ClientWPF.Models.MediatorPattern 5      Q-clr-namespace:DietHolder2ClientWPF.ViewModelsDietHolder2ClientWPF.ViewModels 5
      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      8   2DietHolder2ClientWPF.Views.EatenFoodCalculatorView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z	behaviorsDclr-namespace:WPFTextBoxAutoComplete;assembly=WPFTextBoxAutoComplete     5      �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nmediator9clr-namespace:DietHolder2ClientWPF.Models.MediatorPattern     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      D
viewModels-clr-namespace:DietHolder2ClientWPF.ViewModels     5
      9system&clr-namespace:System;assembly=mscorlib     5      $	��350��5      $	��400��6     � DataContext  5      B  <DietHolder2ClientWPF.ViewModels.EatenFoodCalculatorViewModel  5   
    � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  LabelValuesStyle  TextBoxStyle  TextBoxValuesStyle  DataGridColumnHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  DataGridRowHeaderStyle:  4System.Windows.Controls.Primitives.DataGridRowHeader  DataGridCellStyle*  $System.Windows.Controls.DataGridCell  DataGridStyle&   System.Windows.Controls.DataGrid5  /System.Windows.Controls.DataGridLengthConverter  NormalBrush �� Color 	 NormalBorderBrush 
 HorizontalNormalBrush  HorizontalNormalBorderBrush  ScrollBarLineButton �� 
TargetType �� CornerRadius �� Path	 �� RelativeSource  ScrollBarPageButton  ScrollBarThumb  VerticalScrollBar
 � RowDefinitions J� Opacity ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  ScrollBarStyle �� Triggers P� Property P� Value��%t  &	        &	 �     &	 �    &	     &	 M    &	 j    &	     &	 [    7  7  7  &	 �    &		 �    &	
 
	    &	 +	    &	 T	    7  7 	 &	 G    &	 �    &	     7  7  7  7 
 7  7  7  &	 !    7  �� 5   
   " ��6#   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,0,5,0q�6'   �� 5       � ��$ 14(�6)   �� 5       � ��$ DK Longreach)�6+   �� 5       � ��
 �""��6,   5      �� 5   
   " ��6)   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ New Athletic M54)�6+   �� 5       � ��
 �""��6,   �� 5       � ��$ Center=�65   5      �� 5   
   " ��6%   .�5       ��  � ��$ 25��6'   �� 5!       � ��$ 5,3,5,0q�6'   �� 5"       � ��
 ���� 6,   �� 5#       � ��
 ����6,   �� 5$       � ��$ 0q�60   �� 5%       � ��$ Stretch=�64   �� 5&       � ��$ New Athletic M54)�6+   �� 5'       � ��$ 22(�6)   5(      �� 5)   
   " ��6+   .�5*      ��  � ��
 ���� 6,   �� 5+       � ��$ 0q�60   �� 5,       � ��$ 14(�6)   �� 5-       � ��$ New Athletic M54)�6+   �� 5.       � ��
 �""��6,   �� 5/       � ��$ Center=�64   �� 50       � ��$ Center=�62   51      �� 52   
   "  62   .�53      ��  � ��$ Center=�6;   �� 54       � ��
 ���� 6+   �� 55       � ��
 � E��6+   �� 56       � ��$ 12(�6)   �� 57       � ��$ 
Stika Font)�6+   �� 58       �@ SeparatorBrush
 ��p��60   59      �� 5:   
   "  6/   .�5;      ��  � ��
 ���� 6+   �� 5<       � ��
 ���� 6+   �� 5=       �@ SeparatorBrush
 ���� 60   5>      �� 5?   
   "  6*   .�5@      ��  � ��$ Center=�65   5A      �� 5B   
   "  6&   .�5C      ��  � ��
 ���� 6+   �� 5D       � ��$ 10(�6)   �� 5E       � ��$ 
Stika Font)�6+   �� 5F       �@ ColumnWidth$ * 6,   �� 5G       �@ SelectionMode$ Single=�6.   �� 5H       �@ RowBackground
 ���� 6/   �� 5I       � ��
 ���� 6-   �� 5J       �@ GridLinesVisibility$ 
Horizontal=�65   �� 5K        �@ HorizontalGridLinesBrush
 ���@�6:   �� 5L       �@ ColumnHeaderStyle8   63   �� 5M       �@ RowHeaderStyle8  60   �� 5N       �@ 	CellStyle8  6+   5O      �� 5R   
   $ PaleVioletRed��6.   �� 5S   
   $ Transparent��64   �� 5T   
   $ Crimson��68   �� 5U   
   $ MediumVioletRed��6>   �� 5W   
   " ��6,   .�5X      ��  �@J�SnapsToDevicePixels . 64   �� 5Y       �@�OverridesDefaultStyle . 66   �� 5Z       � |� .  6*   �� 5[       � �� 5\      �� 5]      " ��6&   .R�5^      �� $��Border��5_      $��1q�5`      $ 2��5a      8��  8�� $��1q�5d      ._�5e      F� $��Center=�5f       $��Center=�5g       
����  ���5i       �� $ Content�	 �� *TemplatedParent+5k      5l      5n      5o      �� 5q   
   " ��6,   .�5r      ��  �@J�SnapsToDevicePixels . 64   �� 5s       �@�OverridesDefaultStyle . 66   �� 5t       � �� .  6*   �� 5u       � |� .  6*   �� 5v       � �� 5w      �� 5x      " ��6&   .R�5y      �� 
������ 6!   5z      5|      5}      �� 5   
   " n�6'   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66   �� 5�       � �� .  6*   �� 5�       � |� .  6*   �� 5�       � �� 5�      �� 5�      " n�6&   .R�5�      �� $ 2��5�      #��z��5�      #��z��5�      $��1q�5�      5�      5�      5�      �� 5�   
   " ��5�      .R�5�      � 
 5�      �� 5�      $��18��6$   �� 5�      $��0.00001* �6$   �� 5�      $��18��6$   .+�5�      �� $��3��5�      $ 2��5�      ���#F0F0F0$	 0.6Q�5�      �� 5�      $��0��5�      8��  $��18��5�      $��ScrollBar.LineUpCommand��5�      $��M 0 4 L 8 4 L 4 0 Z��5�      ]� 5�      $��
PART_Track��5�      $��1��5�      ��.  5�      �� 5�      8�� $��ScrollBar.PageUpCommand��5�       5�      n� 5�      8�� $��1,0,1,0q�5�      8�� 8�� 5�       5�      �� 5�      8�� $��ScrollBar.PageDownCommand��5�      5�      �� 5�      $��2��5�      8�� $��18��5�      $��ScrollBar.LineDownCommand��5�      $��M 0 0 L 4 4 L 8 0 Z��5�      5�      5�      �� 5�   
   " ��6'   .�5�      ��  � ��
 ���� 6+   �� 5�       �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66    5�      P� 5�       �@��Orientation$ Vertical=�61   . �5�      ��  � ��$ 14��6.   �� 5�       � ��$
 Auto��6/   �� 5�       � ��8   5�      5�      5�      5�      .��5�      � 
 5�   
   �� 5�      �� 5�      $��25 �6   �� 5�      $��30 �6   �� 5�      $	��100 �6   .+�5�   
   � $��0��6    � ColumnDefinitions 5�      �� 5�      �� 5�      $	��180 �6#   .+�5�      �� $��0��6   $	 0.1Q�6(   ��5�      �� 5�      $ 
Chartreuse��6&   5�        5�      $��0��6      AutoGenerateColumns .  #��[ 5�      ��5�      ��  �� Mode$ OneWay=�$ EatenProductCollection� 5�       �� BasedOn��%0   '��       7  �� 5�      " ��6   8   63   5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�         FontSize$ 10Q�6)      
Foreground
 �i��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6N   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 5�   -   �� $ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�$ ProductName�  5�      $ 10Q�6)   
 �i��$ Carbo��6O    5�   -   �� $ OneWay=�$ PropertyChanged=�$ ProductCarboValue�  5�      $ 10Q�6)   
 �i��$ Protein��6O    5�   -   �� $ OneWay=�$ PropertyChanged=�$ ProductProteinValue�  5�      $ 10Q�6)   
 �i��$	 Fat��6N    5�   -   �� $ OneWay=�$ PropertyChanged=�$ ProductFatValue�5�      �� 5�      $��1��6   $
 0.15Q�6(   ��5�      �� 5�      $ 	Turquoise��6&   5�      >
  8System.Windows.Controls.DataVisualization.Charting.Chart
  5�      $��1��6$   $	��195��64   $	��180��6A   
������ $��0q�5�   $   $
��Left=�68    
  Series 5�      E  ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries    5      �� H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   ItemsSource 5     �� *LeftToEatFoodSummaryDetails+   DependentValueBinding 5     �� $ Value�   IndependentValueBinding 5     �� $	 Key�  
  LegendStyle  5     �� 5     " ��6   .�5     ��  � ��$ 0��62   �� 5      � ��$ 0��63   5	     5     5     �� 5  
   $��1��6   ! �� Orientation$! 
Horizontal=�6"   .+�5     �� $��12(�6   $��25��6"   $��Eaten macros:��6.   #��[ 5     �� 5     $��12(�6   $��25��6"   $��carbo��6.   #��[ 5     �� 5     
��� E��#��[ 5     ��5     �� $ OneWay=�$&  EatenFoodSummaryDetails[0].Value�5     �� 5     $��12(�6   $��25��6"   $��protein��6.   #��[ 5     �� 5     
��� E��#��[ 5     ��5     �� $ OneWay=�$&  EatenFoodSummaryDetails[1].Value�5     �� 5     $��12(�6   $��25��6"   $	��fat��6.   #��[ 5     �� 5     
��� E��#��[ 5     ��5     �� $ OneWay=�$&  EatenFoodSummaryDetails[2].Value�5     5      �� 5"  
   $��2��6   $��0��6!   $
 0.35Q�61   ��5#     �� 5$     $ CornflowerBlue��6"   5&     �� 5'  
   $��2��6   $��Center=�6"   $��0��6?   $	��2.5q�6O   $! 
Horizontal=�6\   .+�5(     � 
�������.+�5)     ]� .+�5*     �� $	��300��5+     $��20��5,     $��Right=�5-     $��Center=�5.     #��[ 51     ��5/     �� $ OneWayToSource=�$ PropertyChanged=�$ UserInputProductName�1   +WPFTextBoxAutoComplete.AutoCompleteBehavior"   AutoCompleteItemsSource" 50     �� $ ProductNamesList�51     �� 52     $��28��6   $��23��6(   $��Right=�63   $
��Left=�6O   $"��../Assets/Icons/FindIcon.png��53      54     55     56     ]� 57  
   $��3��6   $��0��6!   .+�58     �� $
��Left=�6   .+�59     �� $��12(�6   $��	How many?��6&   #��[  6:   � 5:     
�������.+�5;     ]� .+�5<     �� -   5        $��WeightTextbox��5<  -   $��55��6"   #��[ 5=  "   $	��Top=�6H   ��5<  B   �� $ OneWayToSource=�$ 
FoodWeight�5=  H   �� 5>     $��Right=�6    $��28��6<   $��23��6H   $
��Left=�6S   $$��../Assets/Icons/WeightIcon.png��5?      5@     5A     �� 5B     -   5        $��CalculateButton��5B     $	��ADD��5C     $��DK Longreach)�5D     
���<����5F     �� $ 
AddProduct�5G     �� 5I     $	��180��6   $��80��6    $��10q�6,   ��5J     �� $ ImageSourcePath�� 5L     $	��120��6   $��Right=�6   $��Right=�66    5M     �� 5N     �� 5O     �� 5P     
 5R     �� 5S     �� 5T     �� 5U     $��25 �6$   �� 5V     $��22 �6$   .+�5Y     �� $��Center=�6   $��0��65   $��3��6B   $��0��6V   $��Product details��5Z     #��[  62   �� 5[     $��16(�6   $��1��6&   $��0��63   $��3��6C   #��[ 5]     ��5\     �� $ OneWay=�$! SelectedProduct.ProductName�5]     �� 5^     $��2��6   $��0��6%   $	��Top=�65   #��[ 5`     ��5_     �� $ OneWay=�$' !SelectedProduct.ProductCarboValue�5`     �� 5a     $��2��6   $��1��6%   $	��Top=�65   #��[ 5c     ��5b     �� $ OneWay=�$) #SelectedProduct.ProductProteinValue�5c     �� 5d     $��2��6   $��2��6%   $	��Top=�65   #��[ 5f     ��5e     �� $ OneWay=�$% SelectedProduct.ProductFatValue�5f     �� 5g     $��3��6   $��8(�6%   $��0��62   $��Bottom=�6B   $��Carbos��5h     #��[ 5i     �� 5j     $��3��6   $��8(�6%   $��1��62   $��Bottom=�6B   $��Proteins��5k     #��[ 5l     �� 5m     $��3��6   $��8(�6%   $��2��62   $��Bottom=�6B   $
��Fats��5n     #��[ 5o     5p     5q     5r     5s     