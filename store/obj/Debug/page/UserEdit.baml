   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.UserEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5          N� Title$  UserEdit��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Text search��6   $	��175��6/    �� TextAlignment$ Right=�6;   �� 5      -   5        $��
txt_search��5      $	��225��6,   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $
��Type��6   $	��175��6(   $ Right=�64   �� 5      -   5        $��cmp_type��5   E   $	��225��6    �� DisplayMemberPath$ 	type_name��6'   6V   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtg_user��5       $��1��6      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *name+  5!      $
 Gender��6%   $ * 65    6?   �� *Gender1.gender1+  5"      $
 e-mail��6%   $ * 65    6?   �� *e_mail+  5#      $
 phone��6%   $ * 64    6>   �� *phone+4  .System.Windows.Controls.DataGridTemplateColumn  5%      $
 birthday��6+   $ * 6=      CellTemplate 5&      �� 5'      .R�5(      (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6;   �� *
birthday+5)      5*      5,        5/      $
 registration��6%   $ * 6;    6E   �� *data_registration+  50      $

 type��6%   $ * 63    6=   �� *User_type.type_name+  51      -   5        edit��$ * 51   7    52      �� 53      .R�54      �� $��btn_edit��6%   -   5        $
��edit��54   L   55      57      59      5<      5=      