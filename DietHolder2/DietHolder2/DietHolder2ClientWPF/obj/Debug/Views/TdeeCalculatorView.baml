   M S B A M L   `   `   `  ����O  KDietHolder2ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DietHolder2ClientWPF.ViewModelsDietHolder2ClientWPF.ViewModels  5      3    -DietHolder2ClientWPF.Views.TdeeCalculatorView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      D
viewModels-clr-namespace:DietHolder2ClientWPF.ViewModels     5      $	��350��5      $	��400��6     � DataContext  5      =   7DietHolder2ClientWPF.ViewModels.TdeeCalculatorViewModel  5       � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  TextBoxStyle  ComboboxStyle��%,  &	        &	 �     &	 %    �� 5   
   " ��6#   .�5      ��  � ��$ 10,0,5,0q�6'   �� 5       � ��$ 14(�6)   �� 5       � ��$ DK Longreach)�6+   �� 5       � ��
 �""��6,   5      �� 5   
   " ��6%   .�5      ��  � ��$ 25��6'   �� 5       � ��$ 5,3,5,0q�6'   �� 5       � ��
 ���� 6,   �� 5       � ��
 ����6,   �� 5       � ��$ 0q�60   �� 5       � ��$ Stretch=�64   �� 5       � ��$ New Athletic M54)�6+   �� 5       � ��$ 22(�6)   5      �� 5   
   " ��6&   .�5      ��  � ��$ 25��6'   �� 5       � ��$ 5,3,5,0q�6'   �� 5        � ��$ 14(�6)   �� 5!       � ��$ DK Longreach)�6+   �� 5"       � ��
 �<��6,   5#      5$      .��5*      �  � RowDefinitions 5+   
   �� 5,      $��60 �6   �� 5-      $	��220 �6   �� 5.       � ColumnDefinitions 50   
   �� 51      $��* �6   �� 52      $��* �6   .+�55   
   �� $��0��6   $��2��6"   .+�56      �� $��19(�6   #��[  6"   .��6F   Tell me about Yourself...6a   �� 57      $��17(�6   #��[  6"   .��6F   I wanna know Your:6Z   58      �� 5:   
   $��1��6   $��0��6#   .+�5;      �� #��[  6   .��68   Height value6F   � 5<      
�������.+�5=      ]� .+�5>      �� $��Right=�6   $��28��68   $��23��6D   $
��Left=�6O   $$��../Assets/Icons/HeightIcon.png��6e   �� 5?      -   5        $��HeightTextbox��5?      #��[ 5@   p   ��6   ��  �� Mode$ OneWayToSource=� �� UpdateSourceTrigger$ 	LostFocus=�	 �� Path$	 Height�6p   5A      5B      �� 5C      #��[  6   .��68   Weight value6F   � 5D      
�������.+�5E      ]� .+�5F      �� $��Right=�6   $��28��68   $��23��6D   $
��Left=�6O   $$��../Assets/Icons/WeightIcon.png��6e   �� 5G      -   5        $��WeightTextbox��5G      #��[ 5H   o   ��6   �� $ OneWayToSource=�$ 	LostFocus=�$	 Weight�6o   5I      5J      �� 5K      #��[  6   .��68   Age6=   � 5L      
�������.+�5M      ]� .+�5N      �� $��Right=�6   $��28��68   $��23��6D   $
��Left=�6O   $!��../Assets/Icons/AgeIcon.png��6e   �� 5O      -   5        $��
AgeTextbox��5O      #��[ 5P   m   ��6   �� $ OneWayToSource=�$ 	LostFocus=�$		 Age�6m   5Q      5R      �� 5S      #��[  6   .��68   Sex6=   �� 5T      -   5        $��SexCombobox��5T      #��[ 5U      ��5V      �� $ OneTime=�$	 
SexEntries�
 �� SelectedValue
 5W      �� $ OneWayToSource=�$		 Sex�5X      �� 5Z   
   $��1��6   $��1��6#   .+�5[      �� #��[  6   .��68   Somatic type6F   �� 5\      -   5        $��SomaticTypeCombobox��5\      #��[ 5]      ��5^      �� $ OneTime=�$	 SomaticTypeEntries�
 5_      �� $ OneWayToSource=�$	 SomaticType��� 5`      #��[  6   .��68   
Activity6B   �� 5a      -   5        $��DailyActivityCombobox��5a      #��[ 5b      ��5c      �� $ OneTime=�$	 DailyActivityEntries�
 5d      �� $ OneWayToSource=�$	 DailyActivity��� 5e      #��[  6   .��68   Goal6>   �� 5f      -   5        $��GoalToRealizeCombobox��5f      #��[ 5g      ��5h      �� $ OneTime=�$	 GoalToRealizeEntries�
 5i      �� $ OneWayToSource=�$	 GoalToRealize�5j      �� 5m   
   -   5        $��CalculateButton��5n      $��2��5m      $��2��6   $��0��62   $��30��5n   (   $��
10,15,10,0q�64   $��Compute my TDEE value��5o      $��DK Longreach)�5p      
���<��$	��Top=�5r      ��5s      �� *SayHi+5u      5w      