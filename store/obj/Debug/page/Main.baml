   M S B A M L   `   `   `  ����@  <store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:store.page
store.page  5          store.page.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:store.page     5      -   5        $
��test��5	        N� Title$
  Main��6    N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Text search��6   $	��175��6/    �� TextAlignment$ Right=�6;   �� 5      -   5        $��
txt_search��5      $	��225��6,   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Type electronic��6   $	��175��63   $ Right=�6?   �� 5      -   5        $��cmp_type��5   '   $	��225��6    �� DisplayMemberPath$ type_electronic1��68   6]   5      �� 5      -   5        $��
chk_actual��5      $��	available��6e   $��Center=�6y   5      �� 5   
   -   5        $��lst_main��5       $��1��6   $��Disabled=�60   $��Center=�6f   ��5      �� 5       .R�5!      � $ 
Horizontal=�6    $��Center=�69   5"      ��5$      �� 5%      .R�5&      � $��10q�6   $	��400��6'    5'      �� 5(      $��70 �6,   �� 5)      $	��310 �6,   �� 5*      $
��auto �6,   �� 5+      $
��auto �6,   .+�5-      �� $��1��6H   $	��400��6U   $��Center=�6b   $��5q�6   ��6    ��  �� Path$ Products.image�5/      �� 50      $	��390��6K   $
��Wrap=�6W   $��5q�6k   $��26(�6v   $��0��6�   ��6$   �� *Products.name_product+6�   �� 51      $��2��6D   $��5 5 5 15q�6Q   $��26(�6c   $
��Bold"�6q   ��6$   �� *Products.price+6q   �� 52      $��btn_add_basket��6!   -   5        $��
add busket��52   T   $��3��6j   $��14(�6w   $��Right=�6�   �� 53      $��btn_information��6!   -   5        $��More information��53   V   $��3��6q   $��14(�6~   $
��Left=�6�   55      56      58      59      5:      