   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.DealEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5        N� Title$  DealEdit��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��0.36* �6   �� 5      $��* �6   .+�5   
   �� $��id��6   $��26(�6   �� 5   
   -   5        $��txt_id��5   H   $
��Left=�6-   $��1��6V   $��
0 10 15 10q�6f   ��6   �� *	id_deal+6f   �� 5   
   $
��User��6   $��26(�6    $��1��6.   �� 5   
   -   5        $��txt_user��5   Y   $
��Left=�61   $��1��6L   $��1��6i   $��
0 10 15 10q�6y   ��6   �� *Users1.name+6y   �� 5#   
   $��Status��6   $��26(�6"   $��2��60   �� 5$   
   -   5        $��
cmb_status��5$   Z    �� DisplayMemberPath$ status_deal1��69   $��2��6l   $��1��6y   $
��Left=�6�   $��Center=�6�   $	��150��6�    �� SelectedItem 6   �� *Status_deal+6�   �� 5&   
   $
��Date��6   $��26(�6    $��3��6.   �� 5'   
   -   5        $��txt_data��5'   W   $
��Left=�6/   $��3��6J   $��1��6g   $��
0 10 15 10q�6w   ��6   �� *	date_deal+6w   &   System.Windows.Controls.DataGrid  5*   
   -   5        $��dtg_product��5*   4   $��4��6   $��2��6       AutoGenerateColumns .     
IsReadOnly .    Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$	 name product��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Products.name_product+  5-      $	 Price��6%   $
 * 64    6>   �� *Products.price+  5.      $	 
Manufacter��6%   $
 * 69    6C   �� *Products.Manufacturers.name+4  .System.Windows.Controls.DataGridTemplateColumn  5/      $
 * 6)      CellTemplate 50      �� 51      .R�52      �� $��btn_del��6%   -   5        $	��del��52   J   53      55      57      �� 59   
   -   5        $��btn_save��59      $��2��68   $��5��6L   $
��save��6Y   $��16(�6h   5;      5<      