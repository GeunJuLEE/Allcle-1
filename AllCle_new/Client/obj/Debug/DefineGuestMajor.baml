   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClientClient  5          Client.DefineGuestMajor   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Client     5      $	��200��5      $	��400��6     � WindowStartupLocation$  CenterScreen=�6     � WindowStyle$
 None=�6E    � Title$ DefineGuestMajor��6X   .��5
      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��22 �6   �� 5      .+�5   
   �� $��0��6   ���	#FFEFC050._�5      �� $(��"AllCle Guest 전공, 학번 설정��6   
�������$��Center=�6I   $��Center=�6f   $��20(�6�   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      $��0.15* �6#   �� 5      �� 5      .+�5      �� -   5        $��hakbun_cbox��5      $��0��6*    �� SelectedIndex$ 0��6:   $��Center=�6L   .@�5      �� .��6   
19학번6%   �� 5      .��6   
18학번6%   �� 5      .��6   
17학번6%   �� 5      .��6   
16학번6%   �� 5      .��6   
15학번6%   �� 5       .��6   
14학번6%   �� 5!      .��6   
13학번6%   5"      �� 5#      -   5        $��hakbun_cbox_text��5#      $��0��60   $��19학번��6@   $y�	Collapsed=�6L   �� 5&      -   5        $��
major_cbox��5&      $��3��6)   $ 0��69   $��Center=�6K   .@�5'      �� .��6   공과대학6%   �� 5(      .��6   건축대학6%   �� 5)      .��6   일반대학6%   5*      �� 5+      -   5        $��major_cbox_text��5+      $��3��6/   $��공과대학��6?   $y�	Collapsed=�6K   5,      �� 5-   
   -   5        $��2��5-      $��	로그인��6   $��10q�6,   $��0q�69   6M   5.      5/      