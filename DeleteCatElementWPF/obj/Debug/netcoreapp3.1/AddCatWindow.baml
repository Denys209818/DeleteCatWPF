   M S B A M L   `   `   `  ����N  JDeleteCatElementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DeleteCatElementWPFDeleteCatElementWPF  5   	   &     DeleteCatElementWPF.AddCatWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DeleteCatElementWPF     5   	     � Title$,  &Додати новий елемент��5   	   $	��380��6&   $	��450��63   .��5	      � .+�5
   
   �� $	��300��6   .+�5      �� $!��Додати елемент��6   $��Center=�6-   $��24(�6J   
���  ��$
��Bold"�5      $
��0,10q�6&   �� 5      $��
Назва��6   $��16(�6$   $
��Bold"�62   �� 5      -   5         ��Name$ brdName��5      
���  ��$��1q�68   ._�5      �� -   5         ��Name$ txtName��5      $��24(�6+   5      �� 5      $*��$Силка на зображення��6   $��16(�62   $
��Bold"�6@   �� 5      -   5        $ 	brdImgUrl��5      
���  ��$��1q�6:   ._�5      �� -   5        $ 	txtImgUrl��5      $��24(�6-   5      �� 5      $#��Дата народження��6   $��16(�6.   $
��Bold"�6<   �� 5      -   5        $ brdDatePick��5      ._�5      (  "System.Windows.Controls.DatePicker  -   5        $��DateBirthday��5      $��16(�61   5      �� 5      -   5        $��	btnSubmit��5      $��Center=�6&   $	��100��6C   $��50��6O   $��Додати��5      $��20(�6&   $
��Bold"�64   $��0,20,0,0q�5      6'   5       5!      5"      