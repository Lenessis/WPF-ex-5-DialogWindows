   M S B A M L   `   `   `  ����?  ;zad5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad5zad5  5   	       zad5.AddMovie   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad5     5   	   -   5          � Title$  
Dodaj film��5   	   $	��450��6   $	��400��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ]� $��0��6   .+�5      �� $��Tytuł��6   $��5q�6$   $��10q�60   �� 5      -   5        $��
MovieTitle��5      $��5q�6(   $��10q�64   6B   5      ]� 5   
   $��1��6   .+�5      �� $
��Data��6   $��5q�6#   $��10q�6/   (  "System.Windows.Controls.DatePicker  5      -   5        $
��Date��5      $��5q�6%   $��10q�61   5      ]� 5   
   $��2��6   .+�5      �� $
��Opis��6   $��5q�6#   $��10q�6/   �� 5      -   5        $
��Desc��5      $��5q�6"   $��10q�6.   6=   5      � 5    
   $��3��6    � ColumnDefinitions 5"      �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5'      �� -   5        $��Accept��5'   %   $��0��6   $��30,10q�63    �� 	IsDefault$
 True��6N   .��6_   Dodaj6f   �� 5(      -   5        $��1��5(      $��30,10q�6%    �� IsCancel$
 True��6C   .��6S   Anuluj6[   5)      5+      5,      