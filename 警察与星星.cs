       ����  �  9   M ���� �  � V �0�PM �����WDISP_2     �  9  M ��� �   � V �0�PM �����WDISP_3  ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  // This file was decompiled using VCSCM.ini published on 2021-05-25
{$CLEO .cs} 

0000:
:JCTT1_0
wait 0
 var
 1@ : int
 end
1@ = 1 
jump @JCTT1_2
:JCTT1_1
wait 0  //
if 
1@ == 0
then 
wait 1000 
  1@ = 1 // $ == int  
end

if and
   Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 48 //VK_...    0
05EE: 80 //p
jf @JCTT1_1

03E5: text_box 'WDISP_2' 
:JCTT1_2
wait 0  //������Ҫ�������� 
 Player.WantedLevel($PLAYER_CHAR) = 0  //��һ����ӳ٣���������ʱû�뵽�õķ��� 
 if    
 1@ == 1 // $ == int 
then
 wait 1000 
    1@ = 0 // $ == int 
end

 if and
   Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 48 //VK_...
05EE: 80 //p 
jf @JCTT1_2 
03E5: text_box 'WDISP_3' 
jump @JCTT1_1
�   __SBFTR 