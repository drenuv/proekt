   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5           store.page.UserEditCurrent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5        N� Title$  UserEditCurrent��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��203* �6   �� 5      $
��597* �6   .+�5   
   �� $��0��6   $��Name*��6!   $��20(�6.   �� 5   
   -   5        $��Txt_name��5   E   $��0��6(   $��1��65   $��
0 10 10 10q�6U   ��6   �� *name+6U   �� 5   
   $��1��6   $��e-mail*��6!   $��20(�60   �� 5   
   -   5        $��Txt_mail��5   G   $��1��6*   $��1��67   $��
0 10 10 10q�6W   ��6   �� *e_mail+6W   �� 5    
   $��2��6   $��phone��6!   $��20(�6.   �� 5!   
   -   5        $��	Txt_phone��5!   F   $��2��6)   $��1��66   $��
0 10 10 10q�6W   ��6   �� *phone+6W   �� 5#   
   $��3��6   $��data birthday��6!   $��20(�66   (  "System.Windows.Controls.DatePicker  5$   
   -   5        $��data_bithday��5$   7   $��1��6K   $��3��6[   $��Center=�6h   $	��160��6�   $
��Left=�6�   $��30��6�   $
��0,10q�6�      SelectedDate 6   �� *
birthday+6�   �� 5'   
   $��4��6   $��Gender��6!   $��20(�6/   $��26��6=   �� 5(   
   -   5        $��
cmb_Gender��5(   m    �� DisplayMemberPath$ gender1��6   $��4��6P   $��1��6]   $��Center=�6   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��15(�6�   $	��150��6   �� SelectedItem 6/   �� *	Gender1+6  �� 5*   
   $��4��6   $��1��6!   $��Right=�61   $��Type*��6M   $��	0 0 200 0q�6Z   $��20(�6m   $��26��6{   �� 5+   
   -   5        $��cmb_Type��5+   q   $ 	type_name��6   $��4��6T   $��1��6a   $��Center=�6�   $��Center=�6�   $
��Left=�6�   $��Right=�6�   $��15(�6�   $	��150��6
  $��0 0 30 0q�6   61   �� *	User_type+6  �� 5/   
   -   5        $��btn_save��5/   5   $��7��6   $��Save Change��6   $��2��6]   $��
-200 0 0 0q�6q   �� 50   
   -   5        $��btn_new_pas��50   6   $��7��6   $��New password��6   $��2��6d   $��	200 0 0 0q�6x   52      53      