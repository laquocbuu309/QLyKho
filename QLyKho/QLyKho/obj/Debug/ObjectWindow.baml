   M S B A M L   `   `   `  ����A  =QLyKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLyKhoQLyKho  5   	   -clr-namespace:QLyKho.UCToolQLyKho.UCTool  5	   	       QLyKho.ObjectWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:QLyKho     5   	   *ucclr-namespace:QLyKho.UCTool     5	   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     ObjectVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 	VẬT TƯ��5   	   $	��500��6   $	��700��6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5          QLyKho.UCTool.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 window��6J   5       � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5'      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5(      � .+�5)      �� $��5 5 15 5q�6`   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tên Vật Tư��6r    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *DisplayName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5*      $��5 5 15 5q�6    �� DisplayMemberPath$ DisplayName��61   $
 
Đơn vị��6�    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6   ��6Q   �� *Unit+ �� SelectedItem 6n   �� *SelectedUnit+ �� Mode$ TwoWay=�$ PropertyChanged=�6>  �� 5+      $��5 5 15 5q�6   $ DisplayName��61   $
 Nhà cung cấp��6�    . #��[ 6  ��6Q   �� *	Suplier+ 6q   �� *SelectedSuplier+$ TwoWay=�$ PropertyChanged=�6J  �� 5,      $��5 5 15 5q�6[   $
 QR Code��6m   #��[ 6�   ��6   �� *QRCode+$ PropertyChanged=�6�   �� 5-      $��5 5 15 5q�6\   $
 Bar Code��6n   #��[ 6�   ��6   �� *	BarCode+$ PropertyChanged=�6�   5/      50        51      $��1��6"   $��5q�6/   .��52      � $��Center=�6   .+�53      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 54      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 55      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   56      57        58      $��2��6"   $��5q�6/   $��Stretch=�6:   .��59      �� $
��Auto=�6   .��5:      �� ��6   �� *List+ 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5;      �� 5<      .P�5=   "   �� $��ID��61    �� DisplayMemberBinding 6=   �� *Id+6c   �� 5>   "   $��Tên vật tư��61    6E   �� *DisplayName+6t   �� 5?   "   $��
Đơn vị��61    6A   �� *Unit.DisplayName+6u   �� 5@   "   $��Nhà cung cấp��61    6G   �� *Suplier.DisplayName+6~   �� 5A   "   $��QRCode��61    6A   �� *QRCode+6k   �� 5B   "   $��BarCode��61    6B   �� *	BarCode+6m   5C      5E      5F      5G      5H      5I      5J      