   M S B A M L   `   `   `  ����L  HProductionMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProductionMonitorProductionMonitor  5      (    "ProductionMonitor.Views.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProductionMonitor     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ] YPrism.DryIoc.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59V RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5        � Title$  生产执行系统��5	      $
��1200��5
      $	��750��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel True5       � WindowStartupLocation$ CenterScreen=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6   .��5      � ��5   
   
� 5       
� Center$ 0.5,0.5&�5   Q   .��5      �  � Offset$ 0Q�6    � Color$ #285173��6*   � 5      $ 1Q�6   $ #244767��6*   5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��30 �6   .+�5    
   �� ���	#5518aabd$��0,0,0,1q�6)   � 5!   
   $��0��6   	 � ColumnDefinitions	 5#      �� 5$      $��50 �6#   �� 5%      $
��Auto �6#   �� 5&      .+�5)      �� $��35��5*      $��35��5+      $ ��/Resources/Images/logo.jpg��5,      �� 5.      $��1��6   $��Center=�6)   .+�5/      �� $��16(�50      
�������$��生产监控平台��52      �� 53      $��0,3,0,0q�54      $��10(�55      
�������$Y��S道阻且长，行则降至,道阻且长，行则降至,道阻且长，行则降至��57      58      � 59      $��2��6   $��10,0,0,0q�6#    5:      �� 5;      $
��Auto �6$   �� 5<      .+�5>      �� $��0��5?      $
��Auto��5@      $��Right=�5A      $��Center=�5B      
 �� Orientation$
 
Horizontal=�5C         IsHitTestVisibleInChrome$
 True��5D      .+�5E      �� $	����5G         OperateButtonStyle#��[  5H      ��5F      �� *MinimizeCommand+5H      �� 5I      $	����5K      #��[  5L      ��5J      �� *MaxmizeCommand+5L      �� 5M      
���  ��$	����5P      #��[  5Q      ��5O      �� *CloseCommand+5Q      5R      �� 5S      $��1��5T      ���	#5518aabd$��0,1,0,0q�5V      ��5W      !� 5X       j� TileMode$ FlipXY=�5Y       j� Viewport$ 0,0,5,5�5Z       j� ViewportUnits$ Absolute=�5[       !� Visual 5\      �� 5]   "   
�������$��1��5_   %   	 �� X1$ 0��5`   %   	 �� X2$ 5��5a   %   	 �� Y1$ 0��5b   %   	 �� Y2$ 5��5c   %   5e      5g      5h      5i      ]� 5j   
   $��1��6   .+�5k       � $��Stretch=�5l      $��Stretch=�5m      ,  &Prism.Navigation.Regions.RegionManager   
RegionName$ ContentRegion��5n        � NavigationUIVisibility$ Hidden=�5o      5p      �� 5q   
   $��2��5r      ���	#5518aabd$��1q�5t      ._�5u      � 	 5v      �� 5w      �� 5x      $
��Auto �6'   .+�5z      �� $��0��6   ��5{      !� 5|      $ FlipXY=�5}      $ 0,0,5,5�5~      $ Absolute=�5       5�      �� 5�   "   
�������$��1��5�   %   $ 0��5�   %   $ 5��5�   %   $ 0��5�   %   $ 5��5�   %   5�      5�      �� 5�      $��1��5�      $��	20,0,20,0q�5�      $��Right=�5�      $��Center=�5�      $��16(�5�      $
��Bold"�5�      
�������系统版本 1.0.05�      5�      5�      5�      5�      