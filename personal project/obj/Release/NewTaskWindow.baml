   M S B A M L   `   `   `  ����   Personal Project$    Personal_Project.NewTaskWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     �Name$  Window�� � Title$ NewTaskWindow��$	��256��$��263.334�� � WindowStyle$
 None=� � AllowsTransparency . ���	#FFF1F1F1
�������$��2q� � 
ResizeMode$ NoResize=�.��� $��0,0,0,0q� � RowDefinitions �� $��12 ��� $��1* ��� $��5* ��� $��32 �.+��� -   
��������� -    ��Name$ taskname��$��Bottom=�$
��Auto��$��1��$��21.333(� �� MaxLines$ 1�����	#FFEE7A2B   TaskNameBoxStyle#���   �� -    ��Name$ OKbutton��$��Right=�$��OK��$��14(�$��32��$��3��  TextButtons#���  ���	#FFC51212{�.  $��32��$��Bottom=��� -   $��Center=�$
��Left=�$��Cancel��$��14(�$
��Auto��$��3��#���  ���	#FFC51212�� $
��Left=�
�������$��2��$��	10,12,0,0q�$$��I vow to start this task at...��$	��Top=�$��13.333(�(  "System.Windows.Controls.DatePicker  -   	  Name$	 datepick��$��2��$	��Top=�$��13.333(�$��50,106,32,0q��� -   $ hourbox��$��Center=�$��Center=�$
��Left=�$��	50,43,0,0q�$��2��$��00��$��55��$��32(�$ 1��
 �� 	MaxLength$
 2��$��58��$	��Top=�  timeboxstyle#���   � ContextMenu Z� �� -   $ 	minutebox��$��Center=�$��Center=�$��
120,43,0,0q�$��2��$��00��$��32(�$ 1��$
 2��$��55��$��58��$	��Top=�$
��Left=�#���   Z� 	� -	    	�Name$ am��$
��Left=�$��190,43.722,0,0q�$��29��$	��Top=�$��AM��$��30��$��2��  	AMPMRadio#���   d� 	IsChecked$
 TrueY�	� -
   $ pm��$
��Left=�$��190,72.722,0,0q�$��29��$	��Top=�$��PM��$��30��$��2��#���  