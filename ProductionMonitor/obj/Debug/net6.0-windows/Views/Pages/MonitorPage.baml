   M S B A M L   `   `   `  ����L  HProductionMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProductionMonitor.BehaviorsProductionMonitor.Behaviors  5      M+clr-namespace:ProductionMonitor.Views.PagesProductionMonitor.Views.Pages  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      O,clr-namespace:ProductionMonitor.UserControlsProductionMonitor.UserControls  5      /    )ProductionMonitor.Views.Pages.MonitorPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >behavior)clr-namespace:ProductionMonitor.Behaviors     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      7local+clr-namespace:ProductionMonitor.Views.Pages  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      ] YPrism.DryIoc.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59V	 RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5      7uc,clr-namespace:ProductionMonitor.UserControls  	 5        N� Title$  MonitorPage��5      ! 	 Prism.Mvvm.ViewModelLocator   AutoWireViewModel True5      .��5      � 
������  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��12* �6   �� 5      $��3* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $��	20,0,30,0q�5      $��Center=�5      $��Center=�5      $��30(�5       $
��Bold"�5!      
�������$��00:50��5#      � 5$      $��0,0,50,0q�6    5%      �� 5&      �� 5'      .+�5)      �� $��0,10,0,0q�5*      
�������$��2024年12月11日��5,      �� 5-      $��1��5.      $��0,5,0,0q�5/      $��Right=�50      
�������$��	星期三��52      53      54      � 55      $��1��6   $��Stretch=�6#   .+�56      �� $ 
Horizontal=�6   .+�57      �� $��0,0,30,0q�6!   $ 
Horizontal=�63   .+�58      �� $��0,0,20,0q�59      $��Center=�5:      $��Center=�5;      $��13(�5<      
�������$��良品数量��5>      �� 5?      $��Center=�5@      $��Center=�5A      $��16(�5B      
�������$
��1234��5D      5E      �� 5F      $��0,0,30,0q�6!   $ 
Horizontal=�63   .+�5G      �� $��0,0,20,0q�5H      $��Center=�5I      $��Center=�5J      $��13(�5K      
�������$��不良数量��5M      �� 5N      $��Center=�5O      $��Center=�5P      $��16(�5Q      
�������$��13��5S      5T      �� 5U      $ 
Horizontal=�6!   .+�5V      �� $��0,0,20,0q�5W      $��Center=�5X      $��Center=�5Y      $��13(�5Z      
�������$��生产计数��5\      �� 5]      $��Center=�5^      $��Center=�5_      $��16(�5`      
�������$
��1256��5b      5c      5d      �� 5e      $��75��5f      $��35��5g      $��0,0,10,0q�5h      $��Right=�5i      $��配置��5k      $��Right=�5l         PrimaryButtonStyle#��[  5m      
 � Tag$	 ��5n      ��5j      �� *ShowSettingsCommand+5n      5o      5p      � 5q   
   $��1��6   $��20,0,0,0q�6    5r      �� 5s      �� 5t      �� 5u      .+�5w      � $��0��6    5x      �� 5y      �� 5z      �� 5{      .+�5}      �� 
�������$��环境��5        PrimaryGroupBoxStyle#��[ 5�      .��5�      �� $��Center=�5�      $��Center=�5�      ��5�      �� *EnvironemntModelList+��5�      �� 5�      .R�5�   "   A�  A� Columns$ 4��6.   5�      ��5�      �� 5�      .R�5�   "   �� $��5q�6-   .+�5�   &   �� $
��Auto��5�   )   $��5q�5�   )   $��Center=�5�   )   $��Center=�5�   )   $��16(�5�   )   ���	#ff2bedf1��5�   )   �� *	ItemValue+�� 5�   &   $
��Auto��5�   )   $��Center=�5�   )   $��Center=�5�   )   $��14(�5�   )   ���	#ff2bedf1��5�   )   �� *
ItemName+5�   #   5�      5�      5�      �� 5�      $��1��5�      
�������$��产能��5�      #��[ 5�      .��5�      � .+�5�      #  LiveCharts.Wpf.CartesianChart  &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$	 Top=�6-      ChartLegend 5�      "  LiveCharts.Wpf.DefaultLegend  5�   "   	   AxisX	 5�   "     LiveCharts.Wpf.Axis  
   Labels9  3LiveCharts.Wpf.Converters.StringCollectionConverter$K
 E8:00,9:00,10:00,11:00,12:00,13:00,14:00,15:00,16:00,17:00,18:00,19:00 6+      	Separator 5�   &     LiveCharts.Wpf.Separator  5�   *      Step$ 1Q�68      StrokeThickness$ 0Q�6A   5�   #      Series 5�   "   !  LiveCharts.Wpf.ColumnSeries  	  LiveCharts.Wpf.Series 	  Title$ 生产计数��5�   %      MaxColumnWidth$ 15Q�5�   %    	  Values;
  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$5 /120,130,140,150,160.170,180,190,180,170,160,180
 5�   %    	  Fill 5�   &   �� 5�   *    �� 
StartPoint$	 0,0&�6>    �� EndPoint$	 0,1&�6O   .��5�   .   �  � Offset$ 0Q�6;    � Color$ 	#ff3fbbe6��6F   � 5�   .   $ 1Q�6;   $ 	#ff2bedf1��6F   5�   +   5�   #     5�   "   $ 不良计数��5�   %   $ 15Q�5�   %   $# 10,2,11,8,3.22,15,11,2,15,8,9
 5�   %    5�   &   �� 5�   *   $	 0,0&�6>   $	 0,1&�6O   .��5�   .   � $ 0Q�6;   $ 	#fff09a9a��6F   � 5�   .   $ 1Q�6;   $ 	#fff5151a��6F   5�   +   5�   #      AxisY 5�   "        MaxValue$	 500Q�6+      MinValue$ 0Q�6:    5�   &     5�   *   $	 100Q�68      Stroke 5�   .   �� 5�   2    �� Color$ 	#00afafaf��6B   5�   +   5�   #   5�      5�      5�      �� 5�      $��2��5�      
�������$��质量��5�      #��[ 5�      .��5�      � .+�5�        $	 Top=�6-    5�        5�   "   	 5�   "     $K
 E8:00,9:00,10:00,11:00,12:00,13:00,14:00,15:00,16:00,17:00,18:00,19:00 6+    5�   &     5�   *   $ 1Q�68   $ 0Q�6A   5�   #    5�   "     LiveCharts.Wpf.LineSeries  $ 生产计数��5�   %      LineSmoothness$ 1Q�5�   %      PointGeometrySize$ 0Q�5�   %    	  Stroke �	#ff2bedf1$5 /300,130,140,150,160.900,450,190,180,170,160,180
 5�   %    5�   &   �� 5�   *   $	 0,0&�6>   $	 0,1&�6O   .��5�   .   � $ 0Q�6;   $ 	#552bedf1��6F   � 5�   .   $ 1Q�6;   $ Transparent��6F   5�   +   5�   #    5�   "     $	 500Q�6+   $ 0Q�6:    5�   &     5   *   $	 100Q�68    5  .   �� 5  2   $ 	#00afafaf��6B   5  +   5  #   5     5	     5
     5     � 5     $��1��6    5     �� 5     $��2* �6$   �� 5     $��3* �6$   �� 5     $��3* �6$   .+�5     �� $��35��5     $��35��5     $��Stretch=�5     $��Stretch=�5     $ ��/Resources/Images/logo.jpg��5     � 5     $��1��6   $��10,0,0,0q�6$    5     �� 5     $��30 �6(   �� 5     .+�5     �� $ ��/Resources/Fonts/#iconfont)�5     
�������$�� 报警记录��5!     �� 5#     $��1��6#   ��60   �� *	AlarmList+��5$     �� 5%     .R�5&  "   � $��0,5,0,5q�6'    5'  &   �� 5(  *   $��1* �6;   $��5��6F   �� 5)  *   $��1* �6;   $��20��6F   �� 5*  *   $��3* �6;   �� 5+  *   $��3* �6;   �� 5,  *   $��2* �6;   .+�5.  &   �� $��6��5/  )   $��6��50  )   $��Center=�51  )   $��Center=�52  )   
���\\�� �� CornerRadius$ 3��54  )   �� 55  &   $��1��56  )   $��Center=�57  )   $��Center=�58  )   ���	#992bedf1��5:  )   �� *Id+�� 5;  &   $��2��5<  )   $��	10,0,10,0q�5=  )   $��Hidden=�5>  )   $��Hidden=�5?  )   *  $Microsoft.Xaml.Behaviors.Interaction    	Behaviors  5@  *   4   .ProductionMonitor.Behaviors.AutoScrollBehavior  5A  .   !   ScrollSpeed$	! 0.5Q�6J   .��5C  *   �� $��Center=�5D  -   $��Center=�5E  -   ���	#992bedf1��5G  -   �� *	Message+5H  '   �� 5I  &   $��3��5J  )   $��10,0,0,0q�5K  )   $��Hidden=�5L  )   $��Hidden=�5M  )     5N  *     5O  .   $	! 0.5Q�6J   .��5Q  *   �� $��Center=�5R  -   $��Center=�5S  -   ���	#992bedf1��5U  -   �� *	StartTime+5V  '   �� 5W  &   $��4��5X  )   $��Center=�5Y  )   $��Center=�5Z  )   ���	#992bedf1��5\  )   �� *
Duration+5]  #   5^     5`     5a     �� 5b     $��2��5c     $	��0,5q�5d     $��数据异常报警比例��5e     #��[ 5f     .��5g       LiveCharts.Wpf.PieChart  $��0,0,0,20q�6#   "   InnerRadius$" 35Q�65   # � 	Resources# 5h       LiveCharts.Wpf.PieSeries$ �� 
TargetType% �� Property& �� Value��%M  '        �� 5j     "$  6$   .�5k  "   �� % �@	 DataLabelsTemplate& 5l  &   �� 5m  *   .R�5n  .   �� $ 
Horizontal=�69   .+�5o  2   �� $��0,0,5,0q�6<   ��6M   �� *Point.SeriesView.Title+�� 5p  2   ���	#44ffffff��6S   �� *Point.SeriesView.Values[0]+5q  /   5r  +   5t  #   5u     5v      5y       $ 压差��5z  !   ' 	  
DataLabels$
' True��5{  !   (   LabelPosition$( OutsideSlice=�5|  !   ) 	  StrokeThickness$) 0Q�5}  !   $ 20
 5~  !     5     $ 温度��5�  !   $
' True��5�  !   $( OutsideSlice=�5�  !   $) 0Q�5�  !   $ 30
 5�  !     5�     $ 功率��5�  !   $
' True��5�  !   $( OutsideSlice=�5�  !   $) 0Q�5�  !   $ 15
 5�  !     5�     $ 爆炸范围��5�  !   $
' True��5�  !   $( OutsideSlice=�5�  !   $) 0Q�5�  !   $ 77
 5�  !   5�     5�     5�     A� 5�     $��2��6   * A� Rows$* 3��6*   .+�5�     �� $��设备��6   #��[ 6'   .��5�     �� $��Center=�5�     $��Center=�5�     ��5�     �� *
DeviceList+��5�     �� 5�     .R�5�  "   A� $ 4��6.   5�     ��5�     �� 5�     .R�5�  "   �� $��5q�6-   .+�5�  &   �� $
��Auto��5�  )   $��5q�5�  )   $��Center=�5�  )   $��Center=�5�  )   $��16(�5�  )   ���	#ff2bedf1��5�  )   �� *	ItemValue+�� 5�  &   $
��Auto��5�  )   $��Center=�5�  )   $��Center=�5�  )   $��14(�5�  )   ���	#ff2bedf1��5�  )   �� *
ItemName+5�  #   5�     5�     5�     �� 5�     $��能耗��6   #��[ 6'   .��5�     /   )ProductionMonitor.UserControls.RaderChart  +   
ItemSource+ 6$   �� *RaderChartDataList+5�     �� 5�     $��人力��6   #��[ 6'   .��5�     �  5�     �� 5�     $��2* �6/   �� 5�     $��3* �6/   .+�5�     �� $��	0,-30,0,0q�6%   $��Center=�68   .+�5�     �� $��Center=�5�  !   $��25(�5�  !   ���	#99ffffff$	��870��5�  !   �� 5�     $��Center=�5�  !   $��12(�5�  !   ���	#99ffffff$��在职人数��5�  !   5�     � 5�     $��1��6    5�     �� 5�  "   $��30 �60   �� 5�  "   .+�5�     �� $��0,0,0,10q�5�  !   $
��Left=�5�  !   $��Center=�5�  !   $��13(�5�  !   ���	#99ffffff$��缺岗统计��5�  !   �� 5�     $��1��6+   ��68   �� *StuffOutWorkList+��5�  "   �� 5�  &   .R�5�  *   � $��25��6/    5�  .   �� 5�  2   $��10 �6C   �� 5�  2   $
��Auto �6C   $��30��6P   �� 5�  2   $��45 �6C   �� 5�  2   .+�5�  .   �� $��6��5�  1   $��6��5�  1   $��Center=�5�  1   $��Center=�5�  1   
��� ���$ 3��5�  1   �� 5�  .   $��1��5�  1   $��Center=�5�  1   ���	#99ffffbd��5�  1   �� *	StuffName+�� 5�  .   $��2��5�  1   $��Center=�5�  1   $��Center=�5�  1   ���	#99ffffbd��5�  1   �� *
Position+�� 5�  .   $��3��69   $ 
Horizontal=�6I   .+�5�  2   �� $��3��5�  5   $	��5,0q�5�  5   ���	#aa2bedf1��5�  5   �� *OutWorkCount+5�  5   �� 5�  2   $��Center=�5�  5   $��Center=�5�  5   ���	#99ffffbd��5�  5   �� *OutWorkCount+5�  /   5   +   5  '   5     5     5     5     5     5     � 5	  
   $��2��6   .+�5
     �� $��Hidden=�6   $
��Auto=�6B     5     :   4ProductionMonitor.Behaviors.HorizontalScrollBehavior  5     ,   
ScrollStep$, 50Q�68   .��5     �� ��6   �� *WorkShopList+��5     �� 5     .R�5     �� $ 
Horizontal=�6)   5     ��5     �� 5     .R�5     � $	��400��5  !   $��5q�5  !   $��Stretch=�5  !    5  "   �� 5  &   �� 5  &   .+�5  "   � $��0��6'   .+�5  &   �� 
����� �$��0,1,0,0q�6@   �� 5   &   $��10,0,0,0q�5!  )   $
��Left=�5"  )   $��Center=�5#  )   $��16(�5$  )   
���������5&  )   �� *WorkShopName+�� 5'  &   $��0,0,10,0q�5(  )   $��Right=�5)  )   $��Center=�5*  )   
������ $��[详情]��5-  )   
���������5,  )   �� *DataContext.ShowDetail+- �� RelativeSource- �� . �� AncestorType. Page5.  )   5/  #   � 50  "   $��1��6'    51  &   �� 52  *   $��2* �6;   �� 53  *   $��3* �6;   .+�55  &   �� $��Center=�61   $��Center=�6N   .+�56  *   �� $��Center=�57  -   $��Center=�58  -   $��10(�59  -   
�������$��机台总数��5;  -   �� 5<  *   $��Center=�5=  -   $��Center=�5>  -   $��25(�5?  -   
���������5A  -   �� *
TotalNum+5B  '   A� 5C  &   $��1��62   $ 2��6B   .+�5D  *   �� .+�5E  .   �� $��Center=�5F  1   $��Center=�5G  1   $��20(�5H  1   ���	#9932ffff��5J  1   �� *
WorkingNum+�� 5K  .   $��Center=�5L  1   $��Center=�5M  1   $��10(�5N  1   
�������$��作业��5P  1   5Q  +   �� 5R  *   .+�5S  .   �� $��Center=�5T  1   $��Center=�5U  1   $��20(�5V  1   
��� �����5X  1   �� *	WaitNum+�� 5Y  .   $��Center=�5Z  1   $��Center=�5[  1   $��10(�5\  1   
�������$��等待��5^  1   5_  +   �� 5`  *   .+�5a  .   �� $��Center=�5b  1   $��Center=�5c  1   $��20(�5d  1   
���\\����5f  1   �� *
AlarmNum+�� 5g  .   $��Center=�5h  1   $��Center=�5i  1   $��10(�5j  1   
�������$��故障��5l  1   5m  +   �� 5n  *   .+�5o  .   �� $��Center=�5p  1   $��Center=�5q  1   $��20(�5r  1   
���������5t  1   �� *	StopNum+�� 5u  .   $��Center=�5v  1   $��Center=�5w  1   $��10(�5x  1   
�������$��停机��5z  1   5{  +   5|  '   5}  #   5~     5     5�     5�     5�     5�     5�     