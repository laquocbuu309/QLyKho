   M S B A M L   `   `   `  ����A  =QLyKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLyKhoQLyKho  5   	   -clr-namespace:QLyKho.UCToolQLyKho.UCTool  5	   	       QLyKho.AnnounceWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:QLyKho     5   	   *ucclr-namespace:QLyKho.UCTool     5	   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     AnVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Thông Báo��5   	   $	��150��6   $	��350��6(    � AllowsTransparency . 
������ .��5      ��  �� CornerRadius$ 10��6   
�������$��0q�63   
�������._�5   
   � 	 � RowDefinitions	 5      �� 5      $
��Auto �6    60   �� 5      6"   �� 5      $
��auto �6    60   .+�5      �� -   5        
 ��Name$
 Image��5      $��40��6#   $��Center=�6/   $��Center=�6J   $��0��6h   $��1��6u   6�   �� 5      -   5         ��Name$ 	lbContent��5      $��5,5,5,5q�6(   $��Segoe UI)�69   $��15(�6O   
���   �$<��6Đây là thông báo nội dung của chương trình��6p   $��Center=�6�   $��1��6�   $
��auto��6�   $��3��6�   6�   �� 5       $��2��6   $��Center=�6'   $��0,0,0,0q�6D   $	��300��6U   $��40��6a   $��Center=�6m   .+�5!      � 
������ $��Stretch=�60   $��Stretch=�6N    � 	Resources 5"       �� 
TargetType �� Property �� Value��%�   '��       �� 5#      " ��6    .�5$      ��  � ��$ Segoe)�6;   6K   �� 5%       � ��$ 15(�69   6F   �� 5&       � ��$
 Bold"�6;   6J   �� 5'       � ��$ 	5,10,5,10q�67   6K   5(      5)       � ColumnDefinitions 5*      �� 5+      $	��100 �6+   69   �� 5,      $	��100 �6+   69   �� 5-      $	��100 �6+   69   .+�5/      �� -   5         ��Name$ btnOk��5/   -   $��1��6     MaterialDesignRaisedButton#��[ 50      $��OK��51      
�������$��70��6=   
���   �52      �� 54      -   5        $ btnYes��54   -   $��0��6   #��[ 55      $	��YES��56      
��� �|�$��70��6?   
���   ���54   =   �� *
YesCommand+57      �� 59      -   5        $ btnNo��59   -   $��2��6   #��[ 5:      $��NO��5;      
���  ��$��70��67   
���   ���59   =   �� *	NoCommand+5<      5>      5?      5@      5A      5B      