   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.ProductView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5          N� Title$  ProductView��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Text search��6   $	��175��6/    �� TextAlignment$ Right=�6;   �� 5      -   5        $��
txt_search��5      $	��225��6,   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Type electronic��6   $	��175��63   $ Right=�6?   �� 5      -   5        $��cmp_type��5   '   $	��225��6    �� DisplayMemberPath$ type_electronic1��67   6]   5      �� 5      -   5        $��
chk_actual��5      $��	available��6e   $��Center=�6y   5       &   System.Windows.Controls.DataGrid  5"   
   -   5        $��dtg_product��5"       $��1��6      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *name_product+  5%      $
 price��6%   $ * 64    6>   �� *price+  5&      $
 Description��6%   $ * 6:    6D   �� *description+  5'      $
 
Manufacter��6%   $ * 69    6C   �� *Manufacturers.name+  5(      $
 Barcode��6%   $ * 66    6@   �� *	barcode+4  .System.Windows.Controls.DataGridTemplateColumn  5)      $ * 6)   $
 Image��63      CellTemplate 5*      �� 5+      .R�5,      �� $��1��6$   $��UniformToFill=�61   $��Center=�6I   $��5q�6f   ��5-   "   �� 5.   &    �� Path$ image�6.    �� TargetNullValue 5/   *   �� 50   .   ��64   ��  �� Source$- '/store;component/Resources/no_photo.png��6x   52   '   54      55      57        58      $ * 6)    59      �� 5:      .R�5;      �� $��btn_edit��6%   -   5        $
��edit��5;   L   5<      5>      5@      �� 5B   
   -   5        $��btn_add��5B   ,   $��2��6   $	��add��6   $
��Left=�6Q   �� 5C   
   -   5        $��btn_del��5C   ,   $��2��6   $	��del��6   $��Right=�6Q   5F      5G      