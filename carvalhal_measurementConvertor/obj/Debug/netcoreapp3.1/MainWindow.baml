   M S B A M L   `   `   `  ����Y  Ucarvalhal_measurementConvertor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:carvalhal_measurementConvertorcarvalhal_measurementConvertor  5   	   /    )carvalhal_measurementConvertor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:carvalhal_measurementConvertor     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��15 �6   �� 5      $	��150 �6   �� 5      $��25 �6   �� 5      $	��150 �6   �� 5      $��25 �6   �� 5      $	��150 �6    � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��25 �6   .+�5   
   �� $ ��Measurement Converter WPF ��6   $��1��65   $��3��6E   $��1��6Y   $��16(�6f   �� 5   
   $��Convertion Type :��6   $��1��6,   $��3��6<   �� 5   
   -   5        $��cbx_convertionTypes��5      $��0,5,0,0q�5       $��3��5!      $��3��5"      ��5%      �� 5&      .R�5'      ��  �� Orientation$ 
Horizontal=�6!   .+�5(      �� ��6$   �� *Name+5)      5*      5,      �� 5.   
   $��	Convert :��6   $��1��6$   $��4��64   �� 5/   
   -   5         ��Name$ txb_valueIn��5/      $	��0.0��6'   $��3��62   $��4��6B   $��0,5,0,0q�6O   6`   �� 50   
   -   5        $��cbx_convertFrom��50      $��5��6*   $��4��51      $��0,5,0,0q�6    $��50��61   $
��Left=�6<   ��52      �� 53      .R�54      �� $ 
Horizontal=�6!   .+�55      �� ��6$   �� *
UnitName+56      57      59      �� 5:   
   $��Into :��6   $��1��6!   $��5��61   �� 5;   
   -   5         ��Name$ lbl_valueOut��5;      $��3��6P   $��5��6`   $��0,5,0,0q�6m   ��6&   ��  �� Path$ resultConvertion�6m   �� 5<   
   -   5        $��cbx_convertTo��5<      $��5��6(   $��5��5=      $��0,5,0,0q�6    $��50��5>      $
��Left=�6   ��5?      �� 5@      .R�5A      �� $ 
Horizontal=�6!   .+�5B      �� ��6$   �� *
UnitName+5C      5D      5F      �� 5G   
   -   5        $��Convert��5G      $��1��5I      $��8��5J      5K      5L      