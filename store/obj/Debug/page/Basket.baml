   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.Basket   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5          N� Title$  Basket��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dtg_basket��5       $��0��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *name_product+  5      $ price��6%   $ * 64    6>   �� *price+  5      $ 
Manufacter��6%   $ * 69    6C   �� *Manufacturers.name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ * 6)   $ Image��63   	   CellTemplate	 5      �� 5      .R�5      �� $��1��6$   $��UniformToFill=�61   $��Center=�6I   $��5q�6f   ��5   "   �� 5   &   
 �� Path$
 image�6.   5!      5"      5$        5%      $ * 6)   	 5&      �� 5'      .R�5(      �� $��btn_del��6%   -   5        $��del product��5(   J   5)      5+      5-      �� 5/   
   -   5        $��btn_done��5/   6   $��1��6   $��Confirm order��6   $
��Left=�6]   �� 50   
   -   5        $��	btn_clear��50   5   $��1��6   $��clear basket��6   $��Right=�6^   53      54      