   M S B A M L   `   `   `  ����?  ;zad5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad5zad5  5   	       zad5.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad5     5   	     � Title$  Filmy��5   	   $	��450��6   $	��800��6$   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5        $��	MovieList��5      $��0��6   $��5q�60   $��2��6]   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5        $��0��5      $
��10,5q�6%   $��20q�64   .��6Q   Dodaj6X   �� 5      -   5        $��
EditButton��5   @   $��1��6   $
��10,5q�6%   $��20q�64   .��6d   Edytuj6l   �� 5      -   5        $��PreviewButton��5   @   $��2��6   $
��10,5q�6%   $��20q�64   .��6j   
Podgląd6s   �� 5      -   5        $��DeleteButton��5   @   $��3��6   $
��10,5q�6%   $��20q�64   .��6h   Usuń6n   5      5"      5#      