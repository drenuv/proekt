   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.ProductEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5        N� Title$  ProductEdit��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��0.36* �6   �� 5      $��* �6   �� 5      $
��0.6* �6   .+�5   
   �� $
��Name��6   $��26(�6    �� 5   
   -   5        $��txt_name��5   0   $��1��6@   $��
0 10 15 10q�6P   ��6   �� *name_product+6P   �� 5    
   $��id��6   $��26(�6   $��1��6,   �� 5!   
   $��1��60   $
��Left=�6=   $��1��6Y   $��
0 10 15 10q�6i   ��6   �� *
id_product+6i   �� 5#   
   $��description��6   $��26(�6'   $��2��65   �� 5$   
   -   5        $��txt_description��5$   <   $��2��6/   $��1��6S   $��
0 10 15 10q�6c   ��6   �� *description+6c   �� 5&   
   $��Price��6   $��26(�6!   $��3��6/   �� 5'   
   -   5        $��	txt_price��5'   6   $��3��6)   $��1��6G   $��
0 10 15 10q�6W   ��6   �� *price+6W   �� 5)   
   $��
Manufacure��6   $��26(�6&   $��4��64   �� 5*   
   -   5        $��cmb_manufactures��5*   T    �� DisplayMemberPath$
 name��6;   $��4��6l   $��1��6y   $
��Left=�6�   $��Center=�6�   $	��150��6�    �� SelectedItem 6   �� *Manufacturers+6�   �� 5,   
   -   5        $��btn_edit_type��5,      $��4��6&   $��1��63   $��Right=�6_   $��	edit type��6{   �� 5.   
   $��Barcode��6   $��26(�6#   $��5��61   �� 5/   
   -   5        $��txt_barcode��5/   8   $��5��6+   $��1��6K   $��
0 10 15 10q�6[   ��6   �� *	barcode+6[   �� 51   
   -   5        $��img_prod��51   g   $��5��6w   $��2��6�   $��Center=�6�   ��6   ��  �� Path$ image� �� TargetNullValue$- '/store;component/Resources/no_photo.png��52      �� 55   
   -   5        $��btn_save��55      $��2��68   $��6��6L   $
��save��6Y   $��16(�6h   �� 57   
   -	   5        $��btn_add_img��57      $��2��6>   $��6��6N   $��new img��6[   $��16(�6m   59      5:      