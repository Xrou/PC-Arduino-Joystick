   M S B A M L   `   `   `  ���� J  FArduinoJoystick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ArduinoJoystickArduinoJoystick       ArduinoJoystick.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:ArduinoJoystick     -     � Title$   XRou / PC-Arduino Joystick��$	��224��$	��414�� � 
ResizeMode$ NoResize=� � DataContext )  #ArduinoJoystick.MainWindowViewModel  .��� .+��� -    ��Name$ 	Key7Label��$
��Left=�$��	10,10,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key8Label��$
��Left=�$��	65,10,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key9Label��$
��Left=�$��
120,10,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key4Label��$
��Left=�$��	10,65,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key5Label��$
��Left=�$��	65,65,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key6Label��$
��Left=�$��
120,65,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -   $ 	Key1Label��$
��Left=�$��
10,120,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -	   $ 	Key2Label��$
��Left=�$��
65,120,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� -
   $ 	Key3Label��$
��Left=�$��120,120,0,0q�$	��Top=�$��50��$��50��
���   �$��1q��� $
��Left=�$��
181,10,0,0q�$	��Top=�$	��160��$��2��
���   ��� $��скорость��$
��Left=�$��259,119,0,0q�$	��Top=�$��16(��� $��порт��$
��Left=�$��
259,55,0,0q�$	��Top=�$��16(��� $��соединение��$
��Left=�$��
264,10,0,0q�$	��Top=�$��75��$��31������ *ConnectCommand+�� -   $
��Left=�$	��160��$��
188,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��64�� �� 
IsReadOnly . ���� *	LogText+�� $
��Left=�$��
264,83,0,0q�$	��Top=�$	��122������ *AvailableComPorts+ �� SelectedItem �� *SelectedComPort+�� $��264,147,0,0q�$	��Top=�$
��Left=�$	��122������ *AvailableBaudRate+ �� *SelectedBaudRate+�� $��Label��$
��Left=�$��
264,46,0,0q�$	��Top=�$��2��$	��122��
���   ��� $��Label��$
��Left=�$��264,110,0,0q�$	��Top=�$��2��$	��122��
���   ��� $��Label��$
��Left=�$��
257,10,0,0q�$	��Top=�$	��160��$��2��
���   ��� $
��Left=�$��42��$��	14,14,0,0q�$	��Top=�$��42��$��7.png���� $
��Left=�$��42��$��	69,14,0,0q�$	��Top=�$��42��$��8.png���� $
��Left=�$��42��$��
124,14,0,0q�$	��Top=�$��42��$��9.png���� $
��Left=�$��42��$��	14,69,0,0q�$	��Top=�$��42��$��4.png���� $
��Left=�$��42��$��	69,69,0,0q�$	��Top=�$��42��$��5.png���� $
��Left=�$��42��$��
124,69,0,0q�$	��Top=�$��42��$��6.png���� $
��Left=�$��42��$��
14,124,0,0q�$	��Top=�$��42��$��1.png���� $
��Left=�$��42��$��
69,124,0,0q�$	��Top=�$��42��$��2.png���� $
��Left=�$��42��$��124,124,0,0q�$	��Top=�$��42��$��3.png���� $��Label��$
��Left=�$��
10,179,0,0q�$	��Top=�$��1��$	��376��
���   ��� $
��Left=�$��31��$��
356,10,0,0q�$	��Top=�$��31������ *ConnectedDisconnectedPath+