   M S B A M L   `   `   `  ����K  GPersonal Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Personal_ProjectPersonal_Project  5   F   !    Personal_Project.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ,tclr-namespace:Personal_Project     6F   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6o   -   5          � Title$  PlayTime��5   	   $	��520��6   $	��280��6'    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	   ���	#FFC1C1C1$��2,2,2,6q�6@   ���	#FFF1F1F1.��5	      �  � RowDefinitions 5
      �� 5      $��28 �6   �� 5      $	��14* �6   �� 5      $��9* �6   �� 5      $��24 �6   .+�5      �� $��1��6   
���   �$��18.667(�6.      BoxStyle#���   6@   ���	#FFEE7A2B$��Light"�6z   ��5      � 5       � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��25 �6   .+�5      �� $��0��6   $��CURRENT TASKS��6!   �� 5      -   5         ��Name$ NewTask��5      $��1��6     
PlusButton#���  6/   6T   5      .��5      �� $
��Auto=�6   $��Hidden=�65   .��5      �� -   5         ��Name$ CurrentTasksBox��5   %   
�������$��0q�6>   5      5      �� 5      $��2��6   
���   �#���   6.   ���	#FF1C78AC$��Light"�6h   $��14.667(�6{   ��5       �� 5!       �� Orientation$ 
Horizontal=�6   .+�5"      �� $��FUTURE TASKS��6   �� 5#      $��5,2,0,3q�6     
infoButton#���  6   ��5$      �� 5%   	   $��info.png��6   $��16��6!   	 J� OpacityMask
	 �   �6-   
 � ToolTip
 5'      �� 5(   	   97Tasks listed here will not prevent you to launch games.6L   5*      5+      .��5-      �� $
��Auto=�6   $��Hidden=�65   .��5.      �� -   5        $ UpcomingTasksBox��5.   %   
�������$��0q�6?   5/      50      �� 51      -   5        $��0,0,0,0q�51      ���	#FFF1F1F1���	#FFD8D8D8._�52      � .+�53      �� -   5        $��aloha��53      $��28��6   $��28��6)   $��Right=�64   $��0,0,0,0q�6P     MinimizeButtonStyle#���  6{   �� 54      $��Playtime��6   $
��Left=�6   $	��171��6:   $��14.667(�6F   
���   �6X   55      56      �� 57      $��0,0,0,0q�6   $��3��6    $ 
Horizontal=�6-   .+�58      �� -   5        
������ 
������ $
��Left=�58   >   $��3,2,0,2q�6Y   $��3��6j   $
��Auto��6w   $��Light"�6�   $��14.667(�6�   ���	#FF727272��59      � 5:      
������  5;      �� 5<      $��20 �6   .+�5>      �� $��0��6   $��gear settings.png��6   $��
-2,0,-2,-2q�68   $��18��6L   $	��Top=�6X   5?      5A      5B      5C      5D      