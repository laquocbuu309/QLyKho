   M S B A M L   `   `   `  ����A  =QLyKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLyKhoQLyKho  5   	   -clr-namespace:QLyKho.UCToolQLyKho.UCTool  5	   	       QLyKho.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:QLyKho     5   	   *ucclr-namespace:QLyKho.UCTool     5	   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    
 UserVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ THÔNG TIN NGƯỜI DÙNG��5   	   $	��500��6&   $	��600��63   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5           QLyKho.UCTool.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 window��6J   5!      � 5"   
   $��1��6    5#      �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60   �� 5&      6"   .+�5(      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5)      � .+�5*      �� $��5 5 15 5q�6]   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tên đăng nhập��6o    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5+       �� DisplayMemberPath$ DisplayName��6   $��5 5 15 5q�6�   $
 Chức vụ��6�    & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6?   �� *
UserRole+ �� SelectedItem 6`   �� *SelectedRole+ �� Mode$ TwoWay=�$ PropertyChanged=�63  �� 5,      $��5 5 15 5q�6`   $
 Tên hiển thị��6r   #��[ 6�   ��6   �� *DisplayName+$ PropertyChanged=�6�   5.      5/        50      $��1��6"   $��5q�6/   .��51      � $��Center=�6   .+�52      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 53      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 54      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   �� 55      $��Reset Password��6@   $��5q�6Y   $	��130��6d   ��6   �� *ChangePassword+6r   56      57        58      $��2��6"   $��5q�6/   $��Stretch=�6:   .��59      �� $
��Auto=�6   .��5:      �� ��6   �� *List+ 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5;      �� 5<      .P�5=   "   �� $��ID��61    �� DisplayMemberBinding 6=   �� *Id+6c   �� 5>   "   $��Tên đăng nhập��61    6H   �� *
UserName+6t   �� 5?   "   $��Chức vụ��61    6B   �� *UserRole.DisplayName+6z   �� 5@   "   $��Tên hiển thị��61    6G   �� *DisplayName+6v   5B      5D      5E      5F      5G      5I      5J      