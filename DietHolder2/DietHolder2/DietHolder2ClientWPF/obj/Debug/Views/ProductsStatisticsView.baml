   M S B A M L   `   `   `  ����O  KDietHolder2ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DietHolder2ClientWPF.ViewModelsDietHolder2ClientWPF.ViewModels  5      7    1DietHolder2ClientWPF.Views.ProductsStatisticsView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      D
viewModels-clr-namespace:DietHolder2ClientWPF.ViewModels     5      $	��350��5      $	��400��6     � DataContext  5
      A   ;DietHolder2ClientWPF.ViewModels.ProductsStatisticsViewModel  5       � 	Resources 5         DataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value  DataGridRowHeaderStyle:  4System.Windows.Controls.Primitives.DataGridRowHeader  DataGridCellStyle*  $System.Windows.Controls.DataGridCell  DataGridStyle&   System.Windows.Controls.DataGrid5  /System.Windows.Controls.DataGridLengthConverter  
LabelStyle  ComboBoxStyle �� Mode �� Path��%[  &	        &	     &	 �    &	     7   7  7  &	 q    &	 ]    �� 5   
   "  62   .�5      ��  � ��$ Center=�6;   �� 5       � ��
 ���� 6+   �� 5       � ��
 � E��6+   �� 5       � ��$ 12(�6)   �� 5       � ��$ 
Stika Font)�6+   �� 5       �@ SeparatorBrush
 ��p��60   5      �� 5   
   "  6/   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 ���� 6+   �� 5       �@ SeparatorBrush
 ���� 60   5      �� 5   
   "  6*   .�5      ��  � ��$ Center=�65   5      �� 5   
   "  6&   .�5       ��  � ��
 ���� 6+   �� 5!       � ��$ 10(�6)   �� 5"       � ��$ 
Stika Font)�6+   �� 5#       �@ ColumnWidth$ * 6,   �� 5$       �@ SelectionMode$ Single=�6.   �� 5%       �@ RowBackground
 ���� 6/   �� 5&       � ��
 ���� 6-   �� 5'       �@ GridLinesVisibility$ 
Horizontal=�65   �� 5(        �@ HorizontalGridLinesBrush
 ���@�6:   �� 5)       �@ ColumnHeaderStyle8   63   �� 5*       �@ RowHeaderStyle8  60   �� 5+       �@ 	CellStyle8  6+   5,      �� 5-   
   " ��6#   .�5.      ��  � ��$ 11(�6)   �� 5/       � ��$ DK Longreach)�6+   �� 50       � ��
 �""��6,   �� 51       � ��$ Center=�65   �� 52       � ��$ Bottom=�63   53      �� 54   
   " ��6&   .�55      ��  � ��$ 20��6'   �� 56       � ��$ 60��6&   �� 57       � ��$ 12(�6)   �� 58       � ��$ DK Longreach)�6+   �� 59       � ��
 �""��6,   �� 5:       � ��$ Center=�65   �� 5;       � ��$	 Top=�63   �� 5<       � �� 6,   �� $ OneTime=�$ Options��� 5=      % �@��IsSynchronizedWithCurrentItem$ FalseY�6>   5>      5?      .��5A      �  � RowDefinitions 5B   
   �� 5C      �� 5D      �� 5E      .+�5H   
   � $��0��6   $��0��6    � ColumnDefinitions 5I      �� 5J      �� 5K      �� 5L      �� 5M      �� 5N       5P      �� 5Q      �� 5R      �� 5S      .+�5V      �� $��0��6   $��0��6!   #��[ 61   $��Carbo filter��6V   �� 5W      $��0��6   $��1��6!   #��[ 61   $��Protein filter��6U   �� 5X      $��0��6   $��2��6!   #��[ 61   $��
Fat filter��6U   �� 5Y      $��0��6   $��3��6!   #��[ 61   $��Calories filter��6U   �� 5Z      $��0��6   $��4��6!   #��[ 61   $��Price filter��6U   �� 5\      $��1��6   $��0��6$   #��[ 64   	 �� SelectedItem	 5]      �� $ OneWayToSource=�$ SelectedCarboFilter��� 5_      $��1��6   $��1��6$   #��[ 64   
 �� SelectedValue
 5`      �� $ OneWayToSource=�$ SelectedProteinFilter��� 5b      $��1��6   $��2��6$   #��[ 64   
 5c      �� $ OneWayToSource=�$ SelectedFatFilter��� 5e      $��1��6   $��3��6$   #��[ 64   
 5f      �� $ OneWayToSource=�$ SelectedCaloriesFilter��� 5h      $��1��6   $��4��6$   #��[ 64   
 5i      �� $ OneWayToSource=�$ SelectedPriceFilter��� 5l      $��2��6   $��0��6%   $��5��65   ��6I   �� *FilterSummary+5m      �� 5o   
    J� Opacity$	 0.5Q�6   $��1��6"   $��0��6/   ��5p      �� 5q       �� Color$ Azure��6"   5s        5t   
   $��1��6   $��0��6       AutoGenerateColumns .  #��[ 5w      ��5u      �� $ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�$ ProductCollection�   Columns 5x      0  *System.Windows.Controls.DataGridTextColumn  5y         FontSize$ 10Q�6%      
Foreground
 �i��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6J   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 5z   %   �� $ OneWay=�$ PropertyChanged=�$ ProductName�  5{      $ 10Q�6%   
 �i��$ Carbo��6K    5|   %   �� $ OneWay=�$ PropertyChanged=�$ ProductCarboValue�  5}      $ 10Q�6%   
 �i��$ Protein��6K    5~   %   �� $ OneWay=�$ PropertyChanged=�$ ProductProteinValue�  5      $ 10Q�6%   
 �i��$	 Fat��6J    5�   %   �� $ OneWay=�$ PropertyChanged=�$ ProductFatValue�5�      � 5�   
   $��2��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   ��6#   �� $ OneWayToSource=�$ 
RowsNumber��� 5�      $��1��6   ��6"   �� *ShowResultsCommand+5�      5�      5�      