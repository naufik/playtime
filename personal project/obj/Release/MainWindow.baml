   M S B A M L   `   `   `  ���� K  GPersonal Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Personal_ProjectPersonal_Project  !    Personal_Project.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ,tclr-namespace:Personal_Project     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  PlayTime��$	��520��$	��280�� � WindowStyle$
 None=� � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=����	#FFC1C1C1$��2,2,2,6q����	#FFF1F1F1.���  � RowDefinitions �� $��28 ��� $	��14* ��� $��9* ��� $��24 �.+��� $��1��
���   �$��18.667(�   BoxStyle#���   ���	#FFEE7A2B$��Light"����  � ColumnDefinitions �� $��* ��� $��25 �.+��� $��0��$��CURRENT TASKS���� -    ��Name$ NewTask��$��1��  
PlusButton#���  .���� $
��Auto=�$��Hidden=�.���� -    ��Name$ CurrentTasksBox��
�������$��0q��� $��2��
���   �#���   ���	#FF1C78AC$��Light"�$��14.667(�����  �� Orientation$ 
Horizontal=�.+��� $��FUTURE TASKS���� $��5,2,0,3q�  
infoButton#���  ���� $��info.png��$��16��	 J� OpacityMask
	 �   �
 � ToolTip
 �� 97Tasks listed here will not prevent you to launch games..���� $
��Auto=�$��Hidden=�.���� -   $ UpcomingTasksBox��
�������$��0q��� -   $��0,0,0,0q����	#FFF1F1F1���	#FFD8D8D8._�� .+��� -   $��aloha��$��28��$��28��$��Right=�$��0,0,0,0q�  MinimizeButtonStyle#���  �� $��Playtime��$
��Left=�$	��171��$��14.667(�
���   ��� $��0,0,0,0q�$��3��$ 
Horizontal=�.+��� -   
������ 
������ $
��Left=�$��3,2,0,2q�$��3��$
��Auto��$��Light"�$��14.667(����	#FF727272��� 
������  �� $��20 �.+��� $��0��$��gear settings.png��$��
-2,0,-2,-2q�$��18��$	��Top=�