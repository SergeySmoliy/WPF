   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   C ?WpfApp17, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp17WpfApp17 5   	      WpfApp17.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   (localclr-namespace:WpfApp17     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      #  WpfApp17.BoolToStyleConverter   	converter  FontWeightRes �� Type  
Foreground��%  &	        &	      &	       5   
   6%   �� 5   
   " ��6(   .s�5      ��	Black��6    ��5      Bold��6   ��5      DemiBold��6#   ��5      
ExtraBlack��6%   ��5      	ExtraBold��6$   ��5      
ExtraLight��6%   ��5      	Light��6    ��5      	Heavy��6    ��5      
Medium��6!   ��5      
Normal��6!   ��5      Regular��6"   ��5      SemiBold��6#   ��5      Thin��6   ��5      Thin��6   ��5      
UltraBlack��6%   ��5      	UltraBold��6$   ��5      
UltraLight��6%   ��5      Blue��6   ��5      gren��6   5       �� 5"   
   " ��6%   .s�5#      ��	Black��6    ��5$      Blue��6   ��5%      	Green��6    5&      5'      .��5(      �  � RowDefinitions 5.   
   �� 5/      $	��21* �6   �� 50      $	��45* �6   �� 51      $	��23* �6   �� 52      $	��22* �6   �� 53      $
��100* �6    � ColumnDefinitions 56   
   �� 57      �� 59      �� 5<      .+�5@   
   �� $��
Fontweight��6   $��10,10,182.8,8.6q�6&   �� 5O   
   -   5         ��Name$ 	ComboBox1��5O   &   $��	86,10,0,0q�6   $
��Left=�69   $	��Top=�6T   $	��696��6l   $��30��6x   $��3��6�   #��[ 6�   �� 5S   
   $��3��6   $��10,17.4,-10.4,12.2q�6)   $��1��6E    �� Orientation$ 
Horizontal=�6R   .+�5T      �� $��	Fontstyle��6   $��
0,0,-0.4,0q�6*   �� 5U      -   5         ��Name$ 	checkBox1��5U       d� 	IsChecked$
 TrueY�6+   $��20��6<   $��Italic��6H   $��
20 0 0  40q�6Y   5V      �� 5W   
   $��
Foreground��6   $��1��6&   $��10,89.4,183.8,8.6q�63   $��2��6N   �� 5X   
   -   5        $ 	ComboBox2��5X      $
��Left=�6'   $	��Top=�6B   $	��696��6Z   $��30��6f   $��3��6r   $��1��6�   $��86,89.4,0,0q�6�   $��2��6�   #��[ 6�   	 �� SelectedIndex$	 0��6�   5Z      ]� 5\   
   $��2��6   $��3��6!   $��0,44.8,-0.4,0.6q�65   $��2��6N   .+�5]      �� $��Fontsize��6   $��2��6(   $��79��65   $��20 0 0 0q�6@   �� 5^      -   5        
 ��Name$
 textBox1��5^      $��30��6(    �� SelectionBrush
 ��  �$��60��6J   ��6U   ��  �� ElementName$
 slid�� �� Path$ Value��� 5_      -   5         ��Name$
 slid��5_   u    � Value$ 0Q�6    �� SelectionStart$ 0Q�6    $��30��63    �� IsSnapToTickEnabled . $	��0,3q�6[   $	��492��6h    �� Ticks$ 2,4,6,8,10,12R�6�    �� TickFrequency$ 2Q�6�    � Minimum$ 2Q�6�    � Maximum$ 12Q�6�   5b      ]� 5d   
   $��4��6   $��3��6!   .+�5e      �� -   5        $
 textBox4��5e      
 ��  �$	��787��6>   ��6J   �� $ 	checkBox1��$ 	IsChecked� �� 	Converter# [  ��6�   �� $ 	ComboBox1��$ SelectedItem���6�   �� $ 	ComboBox2��$ SelectedValue���6.  �� $
 slid��$ Value�5i      5p      5q      