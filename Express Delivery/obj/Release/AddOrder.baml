   M S B A M L   `   `   `  ���� K  GExpress Delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Express_DeliveryExpress_Delivery      Express_Delivery.AddOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Express_Delivery     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Autorization��$	��587��$	��960�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�.��� ���#28527A.+��� $��Image/Menu.png��$	��Top=�$��Center=�$��2��$��	0,0,0.6,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 4Q�   	Direction$	 270Q�   Opacity$
 0.25Q��� $#��Нове замовлення��$��54(�$��Roboto)�$��DemiBold"�$��39,12,415.6,498.8q��� -   $	��←��$��Global User Interface)�$��788,10,104.6,510.8q����	#FF626262���	#FF323232
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q��� -   $��×��$��Global User Interface)�$��859,10,34.6,510.8q�
���  �����	#FF850000
���   �$��44(�$��Normal"�$
��Auto��$��0q�   $ 9Q��� -    ��Name$ checkBoxRegistered��$��0q�    MaterialDesignAccentCheckBox#��[  ���	#FF8AC4D0���	#FF243CBC � Cursor$
 Hand��$,��& Клієнт зареєстрован��$��Roboto)�$
��22.5(�$��39,97,672.6,449.8q��� -   $��0q�$��620,97,34.6,451.8q�$/��)Зарееструвати клієнта�����	#FFF4D160
���   ����	#FFFBEEAC$��18(�$��Roboto)�$��2q�$
��Auto��� $��0,136,-0.4,-100.2q�.+��� $��39,10,613.6,154.8q�.+��� -   	 ��Name$	 textBoxPasport��$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$!
 Серія паспорту��$
��22.5(�$��8,0,0,0q�$��Roboto)�  MaterialDesignTextBox#��[ $y�	Collapsed=��� -   $	 textBoxName��$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 Ім'я��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[ �� -   $	 textBoxSurname��$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 Прізвише��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[ �� -   $	 textBoxTelephone��$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 Телефон��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[  �� 	MaxLength$ 10���� -	   $	 textBoxWeight��$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 Вага посилки��$
��22.5(�$��8,0,0,0q�$��Roboto)�#��[ �� -
    ��Name$ comboBoxPackage��$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$!
 Вид Упакування��$
��22.5(�$��8,2,8,0q�$��Roboto)�  MaterialDesignComboBox#��[  J� OpacityMask �	#FFE80000�� -   $ comboBoxDelivery��$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 Вид Доставки��$
��22.5(�$��8,2,8,0q�$��Roboto)�#��[ �� -   $ comboBoxCity��$��8,2,8,0q�$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$
 
Місто��$
��22.5(�$��Roboto)�#��[ �� -   $ comboBoxDepartment��$��8,2,8,0q�$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$%
 Номер Відділення��$
��22.5(�$��Roboto)�#��[ {�.  � $��0 15 0 0q�.+��� $
��Left=�$
��22.5(�$��Roboto)�$��Крихкість:��	� -    	�Name$ radioButtonYes��$
��Left=�$��Так��$��112,0,0,2.8q�$
��22.5(�$��Roboto)����	#FF8AC4D0���	#FF8AC4D0$
 Hand��	� -   $ radioButtonNo��$
��Left=�$
��Ні��$��173,0,0,2.8q�$
��22.5(�$��Roboto)����	#FF8AC4D0���	#FF8AC4D0$
 Hand���� $��435,10,99.6,154.8q�.+��� -   $	 textBoxNameReceiver��$��8 0 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$"
 Ім'я отримувача��$
��22.5(�$��Roboto)�#��[ �� -   $	 textBoxSurnameReceiver��$��8 0 0 0q�$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$+
 %Прізвише отримувача��$
��22.5(�$��Roboto)�#��[ �� -   $	 textBoxTelephoneReceiver��$��8 0 0 0q�$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$)
 #Телефон отримувача��$
��22.5(�$��Roboto)�#��[ �� $��0 15 0 0q�$
��Left=�$
��22.5(�$��Roboto)�$(��"Додаткові послуги:���� -   $ checkBoxEnd��$��0 15 0 0q�$��0q�#��[  ���	#FF8AC4D0���	#FF243CBC$
 Hand��$:��4 Зберігання посилки до 7 днів��$��Roboto)�$
��22.5(��� -   $	 
textBoxEnd��$��8 0 0 0q�$��0 15 0 0q�$
��Left=�$	��300��$��26.25��
����������	#FF8AC4D0$3
 -Кількість днів (до 7 днів)��$
��22.5(�$��Roboto)�#��[ {�.  �� -   $ checkBoxReturn��$��0 15 0 0q�$��0q�#��[  ���	#FF8AC4D0���	#FF243CBC$
 Hand��$=��7 Зворотна доставка документів��$��Roboto)�$
��22.5(�� $��0 15 0 0q�.+��� $
��Left=�$
��22.5(�$��Roboto)�$��	Ціна:���� -    ��Name$ textBlockPrice��$
��Left=�$
��22.5(�$��Roboto)�$��0 грн��$��56,0,0,-0.6q��� -   $��620,533,34.6,9.8q�$+��%Оформити замовлення�����	#FFF4D160
���   ����	#FFFBEEAC$��21(�$��Roboto)�$��5q�$
��Auto��