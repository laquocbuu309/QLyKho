   M S B A M L   `   `   `  ����A  =QLyKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLyKhoQLyKho  5   	   -clr-namespace:QLyKho.UCToolQLyKho.UCTool  5	   	       QLyKho.CustomerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:QLyKho     5   	   *ucclr-namespace:QLyKho.UCTool     5	   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     
CustomerVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ KHÁCH HÀNG��5   	   $	��500��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5          QLyKho.UCTool.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 window��6J   5       � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5'      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5(      � .+�5)      �� $��5 5 15 5q�6`   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tên khách hàng��6r    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *DisplayName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5*      $��5 5 15 5q�6\   $
 Địa chỉ��6n   #��[ 6�   ��6   �� *	Address+$ PropertyChanged=�6�   �� 5+      $��5 5 15 5q�6Z   $
 Số điện thoại��6l   #��[ 6�   ��6   �� *Phone+$ PropertyChanged=�6�   �� 5,      $��5 5 15 5q�6Z   $
 Email��6l   #��[ 6�   ��6   �� *Email+$ PropertyChanged=�6�   �� 5-      $��5 5 15 5q�6]   $
 Thông tin thêm��6o   #��[ 6�   ��6   �� *
MoreInfo+$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5.      $��Center=�6!   $	��100��6�   $��5 5 15 5q�6�   $
 Ngày hợp tác��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *ContractDate+$ PropertyChanged=�6�   5/      50        51      $��1��6"   $��5q�6/   .��52      � $��Center=�6   .+�53      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 54      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 55      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   56      57        58      $��2��6"   $��5q�6/   $��Stretch=�6:   .��59      �� $
��Auto=�6   .��5:      �� ��6   �� *List+ �� SelectedItem 6<   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 5;      �� 5<      .P�5=   "   �� $��ID��61    �� DisplayMemberBinding 6=   �� *Id+6c   �� 5>   "   $��Tên khách hàng��61    6K   �� *DisplayName+6z   �� 5?   "   $��Địa chỉ��61    6D   �� *	Address+6o   �� 5@   "   $��Số điện thoại��61    6K   �� *Phone+6t   �� 5A   "   $��Email��61    6@   �� *Email+6i   �� 5B   "   $��Thông tin thêm��61    6I   �� *
MoreInfo+6u   �� 5C   "   $��Ngày hợp tác��61    6J   �� *ContractDate+6z   5D      5F      5G      5H      5I      5J      5K      