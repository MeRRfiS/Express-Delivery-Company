   M S B A M L   `   `   `  ����K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  5   	   !    Express_Delivery.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Express_Delivery     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Autorization��5	   	   $	��587��6   $	��960��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � ���#28527A.+�5   
   �� $
��Left=�6   $	��384��6+   $��22.8,129,0,0q�68   $	��Top=�6N   $	��384��6f   $��Image/E.png��6r   $��1��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 51Q�6#      Opacity$
 0.25Q�63   5      �� 5   
   $��Image/Menu.png��6   $	��Top=�6(   $��Center=�6@   $��2��6]   $��	0,0,0.6,0q�6q    5        5      $ 4Q�6#      	Direction$	 270Q�62   $
 0.25Q�6B   5      �� 5   
   $��Авторизація��6   $��54(�6'   $��Roboto)�65   $��DemiBold"�6I   $��39,12,567.6,476.4q�6_   �� 5   
   -   5        $��×��5      $��Global User Interface)�6   $��859,10,34.6,510.8q�6@   
���  �����	#FF850000
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   $��456.8,166,34.6,103.8q�6   $��1��6/   ._�5      �� .+�5      �� -   5         ��Name$ loginBox��5      $��75��6,   ���	#7F6F5D25���#FBEEAC$��0 40 0 0q�6e   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логін��6w   $��36(�6�   $��Roboto)�6�    !  MaterialDesignOutlinedTextBox#��[  6�   
���   �	 �� 
CaretBrush	 �	#FFFFE500
 � UseLayoutRounding
 .  $��8,15,8,0q�6;   �� SelectionTextBrush �	#FFF4C30A6N  G� 5      -   5         G�Name$ passBox��5      $��75��6/   ���	#7F6F5D25���#FBEEAC$��0 10 0 0q�6h   $ Пароль��6z   $��36(�6�   $��Roboto)�6�    % !MaterialDesignOutlinedPasswordBox#��[ 6�   
���   � G� 
CaretBrush �	#FFFFE500
 .  $��8,15,8,0q�6C   G� SelectionTextBrush �	#FFF4C30A6V  �� 5       -   5        $��0 15 0 0q�5    4   $��75��6F   $��
Війти��6R   $��Global User Interface)�6b   ���#F4D160$��36(�6�   
���   �$��5q�6�   ���	#FFFBEEAC6�   5!      5"      5#      5$      