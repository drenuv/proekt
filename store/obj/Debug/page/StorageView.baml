   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.StorageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5          N� Title$  StorageView��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Product��6   $	��175��6+    �� TextAlignment$ Right=�67   �� 5      -   5        $��
txt_search��5      $	��225��6,   68   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtg_storage��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Name product��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Products.name_product+  5      $	 amount��6%   $
 * 65    6?   �� *amount+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 birthday��6+   $
 * 6=      CellTemplate 5       �� 5!      .R�5"      (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6;   �� *data_delivery+5#      5$      5&        5'      $	 
manufacter��6%   $

 auto 69    6F   �� *Products.Manufacturers.name+  5)      $
 * 6)    5*      �� 5+      .R�5,      �� $��btn_edit��6%   -   5        $
��edit��5,   L   5-      5/      51      �� 53   
   -   5        $��btn_add��53   ,   $��2��6   $	��add��6   $
��Left=�6Q   �� 54   
   -   5        $��btn_del��54   ,   $��2��6   $	��del��6   $��Right=�6Q   56      57      