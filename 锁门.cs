�LOCKTT          � C V M ���� ���� �����  9  M ���� -��� ���� ����  �  9   M X����   ?   
  �GUANMEN    �  � V �  �	M 4��� -��� ����  ?   
   � KAIMEN  �    �  �  �  M ����� V �	M  ��� ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC q  {$CLEO .cs}
//���ϳ�ʱ���ţ���Tab�����ţ��ڳ��ϣ����뿪��ʱ���� 
//039E  SET_CHAR_CANT_BE_DRAGGED_OUT
script_name 'LOCKTT'
var 
1@ :int =0
2@ : int = 0
end 
:LOCKTT_1
wait 0
if  and
0443:   player $PLAYER_CHAR sitting_in_any_car
Player.Defined($PLAYER_CHAR)
then
 jump @LOCKTT_L
else
if 1@ == 1
then 
jump @LOCKTT_O
else 
jump @LOCKTT_1
end
end

:LOCKTT_L
wait 0
if 
1@ == 0
jf @LOCKTT_L1
 
03C1: 0@ = player $PLAYER_CHAR car_no_save 
053F: set_car 0@ tires_vulnerable 0 
020A: set_car 0@ door_status_to 2 
  03E5: text_box  'GUANMEN'
1@=1 
wait 1000
:LOCKTT_L1         
wait 0
if and
   Player.Defined($PLAYER_CHAR)
00E0:   player $PLAYER_CHAR in_any_car 
05EE:   key_pressed 9 //VK_...  tab
then 
jump @LOCKTT_O
end 
jump @LOCKTT_1


:LOCKTT_O
wait 0 
053F: set_car 0@ tires_vulnerable 0 
020A: set_car 0@ door_status_to 0 
00BC: text_highpriority 'KAIMEN' time 1000 1 
1@=0 
wait 1000 
:LOCKTT_O1
wait 0
if 
00E0:   player $PLAYER_CHAR in_any_car 
jf @LOCKTT_1
if and
   Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 9 //VK_...  tab
jf @LOCKTT_O1

jump @LOCKTT_1

/  __SBFTR 