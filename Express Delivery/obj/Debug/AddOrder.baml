   M S B A M L   `   `   `  ����K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery  5   	       Express_Delivery.AddOrder   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Express_Delivery     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Autorization��5	   	   $	��587��6   $	��960��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5
      � ���#28527A.+�5   
   �� $��Image/Menu.png��6   $	��Top=�6(   $��Center=�6@   $��2��6]   $��	0,0,0.6,0q�6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 4Q�6#      	Direction$	 270Q�62      Opacity$
 0.25Q�6B   5      �� 5   
   $#��Нове замовлення��6   $��54(�6+   $��Roboto)�69   $��DemiBold"�6M   $��39,12,415.6,498.8q�6c   �� 5   
   -   5        $	��←��5      $��Global User Interface)�6   $��788,10,104.6,510.8q�6@   ���	#FF626262���	#FF323232
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   -   5        $��×��5      $��Global User Interface)�6   $��859,10,34.6,510.8q�6@   
���  �����	#FF850000
���   �$��44(�6�   $��Normal"�6�   $
��Auto��6�   $��0q�6�    5        5      $ 9Q�6#   5      �� 5   
   -   5         ��Name$ checkBoxRegistered��5      $��0q�6/       MaterialDesignAccentCheckBox#��[  6;   ���	#FF8AC4D0���	#FF243CBC � Cursor$
 Hand��6�   $,��& Клієнт зареєстрован��6�   $��Roboto)�6�   $
��22.5(�6�   $��39,97,672.6,449.8q�6�   6  �� 5      -   5        $��0q�5      $��620,97,34.6,451.8q�6!   $/��)Зарееструвати клієнта��6<   ���	#FFF4D160
���   ����	#FFFBEEAC$��18(�6�   $��Roboto)�6�   $��2q�6�   $
��Auto��6�   6�   � 5      $��0,136,-0.4,-100.2q�6   .+�5      �� $��39,10,613.6,154.8q�6   .+�5      �� -   5        	 ��Name$	 textBoxPasport��5      $
��Left=�66   $	��300��6Q   $��26.25��6]   
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$!
 Серія паспорту��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�     MaterialDesignTextBox#��[ 6�   $y�	Collapsed=�6,  �� 5       -   5        $	 textBoxName��5       $
��Left=�63   $	��300��6N   $��26.25��6Z   
����������	#FF8AC4D0$
 Ім'я��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[ 6�   �� 5!      -   5        $	 textBoxSurname��5!      $��0 15 0 0q�66   $
��Left=�6H   $	��300��6c   $��26.25��6o   
����������	#FF8AC4D0$
 Прізвише��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[ 6	  �� 5"      -   5        $	 textBoxTelephone��5"      $��0 15 0 0q�68   $
��Left=�6J   $	��300��6e   $��26.25��6q   
����������	#FF8AC4D0$
 Телефон��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[ 6
   �� 	MaxLength$ 10��69  �� 5#      -	   5        $	 textBoxWeight��5#      $��0 15 0 0q�65   $
��Left=�6G   $	��300��6b   $��26.25��6n   
����������	#FF8AC4D0$
 Вага посилки��6�   $
��22.5(�6�   $��8,0,0,0q�6�   $��Roboto)�6�   #��[ 6  6;  �� 5$      -
   5         ��Name$ comboBoxPackage��5$      $��0 15 0 0q�68   $
��Left=�6J   $	��300��6e   $��26.25��6q   
����������	#FF8AC4D0$!
 Вид Упакування��6�   $
��22.5(�6�   $��8,2,8,0q�6�   $��Roboto)�6�     MaterialDesignComboBox#��[ 6   J� OpacityMask �	#FFE800006A  �� 5%      -   5        $ comboBoxDelivery��5%      $��0 15 0 0q�69   $
��Left=�6K   $	��300��6f   $��26.25��6r   
����������	#FF8AC4D0$
 Вид Доставки��6�   $
��22.5(�6�   $��8,2,8,0q�6�   $��Roboto)�6�   #��[ 6  6@  �� 5&      -   5        $ comboBoxCity��5&      $��8,2,8,0q�65   $��0 15 0 0q�6G   $
��Left=�6Y   $	��300��6t   $��26.25��6�   
����������	#FF8AC4D0$
 
Місто��6�   $
��22.5(�6�   $��Roboto)�6�   #��[ 6  65  �� 5'      -   5        $ comboBoxDepartment��5'      $��8,2,8,0q�6;   $��0 15 0 0q�6M   $
��Left=�6_   $	��300��6z   $��26.25��6�   
����������	#FF8AC4D0$%
 Номер Відділення��6�   $
��22.5(�6�   $��Roboto)�6  #��[ 6  {�.  6F  � 5(      $��0 15 0 0q�6   .+�5)      �� $
��Left=�6$   $
��22.5(�6?   $��Roboto)�6O   $��Крихкість:��6c   	� 5*      -   5         	�Name$ radioButtonYes��5*   &   $
��Left=�6>   $��Так��6Y   $��112,0,0,2.8q�6g   $
��22.5(�6|   $��Roboto)�6�   ���	#FF8AC4D0���	#FF8AC4D0$
 Hand��6�   	� 5+      -   5        $ radioButtonNo��5+   &   $
��Left=�6=   $
��Ні��6X   $��173,0,0,2.8q�6e   $
��22.5(�6z   $��Roboto)�6�   ���	#FF8AC4D0���	#FF8AC4D0$
 Hand��6�   5,      5-      �� 5.      $��435,10,99.6,154.8q�6   .+�5/      �� -   5        $	 textBoxNameReceiver��5/      $��8 0 0 0q�6;   $
��Left=�6M   $	��300��6h   $��26.25��6t   
����������	#FF8AC4D0$"
 Ім'я отримувача��6�   $
��22.5(�6�   $��Roboto)�6�   #��[ 6  �� 50      -   5        $	 textBoxSurnameReceiver��50      $��8 0 0 0q�6>   $��0 15 0 0q�6P   $
��Left=�6b   $	��300��6}   $��26.25��6�   
����������	#FF8AC4D0$+
 %Прізвише отримувача��6�   $
��22.5(�6�   $��Roboto)�6  #��[ 6  �� 51      -   5        $	 textBoxTelephoneReceiver��51      $��8 0 0 0q�6@   $��0 15 0 0q�6R   $
��Left=�6d   $	��300��6   $��26.25��6�   
����������	#FF8AC4D0$)
 #Телефон отримувача��6�   $
��22.5(�6�   $��Roboto)�6	  #��[ 6  �� 52      $��0 15 0 0q�6    $
��Left=�62   $
��22.5(�6M   $��Roboto)�6]   $(��"Додаткові послуги:��6q   �� 53      -   5        $ checkBoxEnd��53      $��0 15 0 0q�64   $��0q�6F   #��[  6R   ���	#FF8AC4D0���	#FF243CBC$
 Hand��6�   $:��4 Зберігання посилки до 7 днів��6�   $��Roboto)�6�   $
��22.5(�6  6  �� 54      -   5        $	 
textBoxEnd��54      $��8 0 0 0q�62   $��0 15 0 0q�6D   $
��Left=�6V   $	��300��6q   $��26.25��6}   
����������	#FF8AC4D0$3
 -Кількість днів (до 7 днів)��6�   $
��22.5(�6�   $��Roboto)�6  #��[ 6  {�.  6X  �� 55      -   5        $ checkBoxReturn��55      $��0 15 0 0q�67   $��0q�6I   #��[  6U   ���	#FF8AC4D0���	#FF243CBC$
 Hand��6�   $=��7 Зворотна доставка документів��6�   $��Roboto)�6�   $
��22.5(�6  6  � 56      $��0 15 0 0q�6   .+�57      �� $
��Left=�6$   $
��22.5(�6?   $��Roboto)�6O   $��	Ціна:��6c   �� 58      -   5         ��Name$ textBlockPrice��58   $   $
��Left=�6<   $
��22.5(�6W   $��Roboto)�6g   $��0 грн��6{   $��56,0,0,-0.6q�6�   59      5:      5<      �� 5=      -   5        $��620,533,34.6,9.8q�5=      $+��%Оформити замовлення��6/   ���	#FFF4D160
���   ����	#FFFBEEAC$��21(�6�   $��Roboto)�6�   $��5q�6�   $
��Auto��6�   6�   5?      5@      