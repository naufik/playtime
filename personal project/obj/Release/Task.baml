   M S B A M L   `   `   `  ����   Personal Project    Personal_Project.Task   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     >�Name$  	TaskEntry��$��40��$
��Auto�� � 	Resources    TaskBox �� 
TargetType �� Property �� Value �� 
TargetType �� Stretch A�Name �� Triggers	 P� Property
 P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%�  &	        �� " �����  � �� �� " ��.R�� .+�A� $
��Auto��$
��Auto��$
 Fill=�
������ ���	#FFEE7A2B$��2��A� $ InnerCircle��$
��Auto��$
��Auto��$��4q����	#FFEE7A2B$
 Fill=� P� 	 �@d�	IsChecked$
 FalseY�. ��� $ InnerCircle�� � ��
 ���� ]�  ��  �@J�IsMouseOver . ��  �@d�	IsChecked$ FalseY�./��� $ InnerCircle�� � ��
 �����.��� -    �Name$ Layout��$��40��$
��Auto�� � RowDefinitions �� $��7* ��� $��5* � � ColumnDefinitions �� $��30 ��� $
��Auto �.+��� -    ��Name$ check��$��0��$��0��$��2��$��30��#���    d� 	IsChecked ��  �� Path$ 	IsChecked� �� ElementName$ 	TaskEntry���� $��0��$��1��$��Medium"�$��16(����	#FFEE7A2B$
��Left=�$��5,0,0,0q�$��Bottom=����� $ TaskName�$ 	TaskEntry���� $��1��$��1��
�������$
��Left=�$	��Top=�$��5,0,0,0q�$��13.333(����� $ TaskTime� �� StringFormat$" {0:MMMM dd, yyyy - hh:mm tt}��$ 	TaskEntry��