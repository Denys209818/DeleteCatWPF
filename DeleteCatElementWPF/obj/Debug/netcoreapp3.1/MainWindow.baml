   M S B A M L   `   `   `  ����N  JDeleteCatElementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DeleteCatElementWPFDeleteCatElementWPF  5   	   $    DeleteCatElementWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DeleteCatElementWPF     5   	   -   5          � Title$  Головна форма��5   	   $	��450��6   $	��800��6,   .��5	      ]� .+�5
   
   �� $��Right=�6   $	��200��6,   
�������.+�5      �� -   5        $��btnAdd��5      $!��Додати елемент��6#   $��40��6Q   $
��Auto��6]   $��10q�6j   �� 5      -   5        $��btnDel��5      $%��Видалити елемент��6#   $��40��6S   $
��Auto��6_   $��10q�6l   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgCats��5   /      AutoGenerateColumns$ False��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Назва��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Name+6M   4  .System.Windows.Controls.DataGridTemplateColumn  5      $# Дата народження��6)   $ 3* 6B      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker  $��datePick��6K      SelectedDate 6)   �� *
Birthday+6K   5      5         RowDetailsTemplate 5      �� 5      .R�5      � .+�5      �� $
��Fill=�6:   $��64��6I   $��64��6T   $��10q�6`   ��6    �� *ImgUrl+6`   � 5      $��10q�6   	 � ColumnDefinitions	 5      �� 5   "   �� 5    "   
 � RowDefinitions
 5"      �� 5#   "   �� 5$   "   �� 5%   "   .+�5(      �� $
��ID: ��6(   $
��Bold"�64   $��12(�6F   $��0��6T   $��0��6a   �� 5)      $��Назва: ��6(   $
��Bold"�67   $��12(�6I   $��1��6W   $��0��6d   �� 5*      $%��Дата народження: ��6(   $
��Bold"�6A   $��12(�6S   $��2��6a   $��0��6n   �� 5,      $��12(�6<   $��0��6J   $��1��6W   ��6(   �� *Id+6W   �� 5-      $��12(�6>   $��1��6L   $��2��6Y   ��6(   �� *Name+6Y   �� 5.      $��12(�6B   $��2��6P   $��3��6]   ��6(   �� *
Birthday+6]   5/      50      51      53      54      55      