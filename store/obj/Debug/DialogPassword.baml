   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:storestore  5   	       store.DialogPassword   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:store     5   	     � Title$  DialogPassword��5   	   $	��190��6    $	��400��5	      $	��300��5
      $	��400��5       � 
ResizeMode$ CanResizeWithGrip=�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Change password��6   $��2��6*   �� 5   
   -   5        $��txt_old��5      $y�Hidden=�6#   $��old password��67   $��1��6K   G� 5    
   -   5        $��psw_old��5    *   $y�Hidden=�6   $��1��69   $��1��6F   �� 5"   
   $��new password��6   $��2��6(   G� 5#   
   -   5        $��psw_new��5#      $��2��6%   $��1��62   �� 5%   
   $��confirm new password��6   $��3��60   G� 5&   
   -   5        $��psw_new_confirm��5&      $��3��6-   $��1��6:   �� 5(   
   -   5        $��4��5(       �� 	IsDefault . $��OK��6E   �� 5)   
   $��4��6   $��1��6    �� IsCancel . $��Cansel��6>   5+      5,      