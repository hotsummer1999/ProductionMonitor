   M S B A M L   `   `   `  ����L  HProductionMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ProductionMonitor.ViewsProductionMonitor.Views  5      ,    &ProductionMonitor.Views.SettingsWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ProductionMonitor.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ] YPrism.DryIoc.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59V RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5        N� Title$  SettingsWindow��5	      $	��800��5
      $	��450��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel True5       N� 
Background
 ����  N� FontSize$ 14(�5      .��5      � $
��20,0q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   .+�5   
   �� $
��Left=�5      $��Center=�5      $ ��/Resources/Fonts/#iconfont)�5      $�� 系统配置信息��5       �� 5"   
   $��1��5#      ���	#4400aabd$��0,0,1,0q�5%      �� 5'   
   $��1��6   $
��10,0q�6"   .+�5(      	� $
��Auto��5)      $��40��5*      $��设备清单��5+      $��16(�5,       d� 	IsChecked$
 TrueY�5-         PrimaryRadioButtonStyle#��[  5.      	� 5/      $
��Auto��50      $��40��51      $��环境监测��52      $��16(�53      #��[  54      	� 55      $
��Auto��56      $��40��57      $��设备监测��58      $��16(�59      #��[  5:      	� 5;      $
��Auto��5<      $��40��5=      $��	配置一��5>      $��16(�5?      #��[  5@      	� 5A      $
��Auto��5B      $��40��5C      $��	配置二��5D      $��16(�5E      #��[  5F      5G      5H      5I      