   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.DealVIew   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5          N� Title$  DealVIew��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��id deal��6   $	��175��6+    �� TextAlignment$ Right=�67   �� 5      -   5        $��
txt_search��5      $	��225��6,   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Status Deal��6   $	��175��6/   $ Right=�6;   �� 5      -   5        $��cmp_type��5   '   $	��225��6    �� DisplayMemberPath$ status_deal1��67   6Y   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtg_deal��5       $��1��6      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 id deal��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *	id_deal+  5       $
 Status��6%   $ * 65    6?   �� *Status_deal.status_deal1+  5!      $

 User��6%   $ * 63    6=   �� *Users1.name+  5"      $

 User��6%   $ * 63    6=   �� *	date_deal+4  .System.Windows.Controls.DataGridTemplateColumn  5$      $ * 6)      CellTemplate 5%      �� 5&      .R�5'      �� $��btn_edit��6%   -   5        $
��edit��5'   L   5(      5*      5,      5.      5/      