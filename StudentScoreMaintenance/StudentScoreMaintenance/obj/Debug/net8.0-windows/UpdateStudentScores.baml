   M S B A M L   `   `   `  ����R  NStudentScoreMaintenance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StudentScoreMaintenanceStudentScoreMaintenance  5   	   1    +StudentScoreMaintenance.UpdateStudentScores   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:StudentScoreMaintenance     5   	     � Title$  Update Student Scores��5   	   $	��247��6'   $	��398��64   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��Name:��6   $
��Left=�6    $��	13,14,0,0q�6;   $	��Top=�6N   �� 5   
   $��Scores:��6   $
��Left=�6"   $��	13,45,0,0q�6=   $	��Top=�6P    J� RenderTransformOrigin$ -0.406,-1.598&�6h   �� 5   
   -   5         ��Name$ 	lstScores��5      $
��Left=�6P   $��	70,54,0,0q�6k   $	��Top=�6~   $��95��6�   $	��164��6�   �� 5   
   -   5         ��Name$ btnAdd��5      $
��_Add��6!   $
��Left=�60   $��
239,54,0,0q�6K   $	��Top=�6_   $��72��6w   $��1��6�   �� 5   
   -   5        $ 	btnUpdate��5      $��_Update��6$   $
��Left=�66   $��
239,79,0,0q�6Q   $	��Top=�6e   $��72��6}   $��2��6�   �� 5   
   -   5        $ 	btnRemove��5      $��_Remove��6$   $
��Left=�66   $��239,104,0,0q�6Q   $	��Top=�6f   $��72��6~   $��3��6�   �� 5   
   $��Clear _Scores��6   $
��Left=�6)   $��239,129,0,0q�6D   $	��Top=�6Y   $��64��6q   �� 5   
   -   5        $��Clear _Scores��5      $
��Left=�6)   $��239,129,0,0q�6D   $	��Top=�6Y   $��72��6q   $��4��6�   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��	70,22,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   ${�False��6�   �� 5   
   -   5        $ btnClose��5      $��_Close��6#   $
��Left=�64   $��239,179,0,0q�6O   $	��Top=�6d   $��64��6|   $��6��6�   �� 5   
   -   5        $ btnOK��5      $	��_OK��6    $
��Left=�6.   $��170,179,0,0q�6I   $	��Top=�6^   $��64��6v   $��5��6�   5      5      