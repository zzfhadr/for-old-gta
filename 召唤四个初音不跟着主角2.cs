�CYSJ  � 	   
    � V m �Z�1M �����     ���?       U     � V m �Z�2M T����     ���?       U     � V m �Z�3M ����     ���?       U     � V m �Z�4M �����     ���?       U     � V �D�4M H��� 
�  m M �����   
�  m M z����   
�  m M a����   
�  m M H����  � V �C�4M ����	 	 �  9 	 M ����<CHU1  D�
 
 �CHU1_ D�  9 	 M ����<CHU3  A�
 
 �CHU3_ )	�  9 	 M ����<CHU4  )	�
 
 �CHU4_ )	�  9 	 M c���<CHU5  C	�
 
 �CHU5_ C	�  9 	 M 2���<CHU6  C	�
 
 �CHU6_ C	�  9 	 M ���<CHU7  C	�
 
 �CHU7_ C	�  9 	 M ����<CHU8  C	�
 
 �CHU8_ C	�  9 	 M ����<CHUY1 C	�
 
 �CHUY1_  �  9 	 	M n���<CHUY2 C	�
 
 �CHUY2_  �  9 	 
M =���<CHUY3 C	�
 
 �CHUY3_  �  9 	 M ���<CHUY5 C	�
 
 �CHUY5_  �  9 
 M ���� �����  9 
 M ���� �����  9 
 M ���� 
����  9 
 M ���� K����  9 
 M ���� 
  ����  �  =M �����  m M `����  p  �     ���?       �  m    # �� � !�� C � � � Z  ��o� � ����  �  =M �����  m M �����  p  �     ���?       �  m    # �� � !�� C � � � Z  ��o� � ����  �  =M �����  m M �����  p  �     ���?       �  m    # �� � !�� C � � � Z  ��o� � ����  �  =M �����  m M #����  �     ���?       �  m    # �� � !�� C � � � Z  ��o� � ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �*  {$CLEO .cs}
//press c and 4 to creat
//press z and 1-4 to teleport to miku in 1-4.
// 034F: destroy_actor_with_fade $1037 // The actor fades away like a ghost freeing game memory 
script_name 'CYSJ' 
var
      //2 (3 4 5) (9 10) (11 7 8 6)   \ 0 1
9@ : int = 0
10@ : int =0
end
 //036A

:CYSJ_1
wait 0 

/* //come
if and
Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 76 //VK_...  L 
05EE:   key_pressed 50 //VK_... 2      //�ó�������    i feel this one is meanless
then                                   //instead of letting miku come, why don't create a new one
04C4: create_coordinate 3@ 4@ 5@ from_actor $PLAYER_ACTOR offset 0.0 1.2 0.0 
if
056D:   actor 6@ defined
then
00A1: put_actor 6@ at 3@ 4@ 5@
end
wait 500
if
056D:   actor 7@ defined
then
00A1: put_actor 7@ at 3@ 4@ 5@
end
wait 500
if
056D:   actor 8@ defined
then
00A1: put_actor 8@ at 3@ 4@ 5@
end
wait 500
if
056D:   actor 11@ defined
then
00A1: put_actor 11@ at 3@ 4@ 5@
end

end
 */
//go 
if and
Player.Defined($PLAYER_CHAR)
056D:   actor 6@ defined
05EE:   key_pressed 90 //VK_... Z
05EE:   key_pressed 49 //VK_... 1    //��ȥ�������� 
then
04C4: create_coordinate 3@ 4@ 5@ from_actor 6@ offset 0.0 1.2 0.0 
0055: put_player $PLAYER_CHAR at 3@ 4@ 5@
end

if and
Player.Defined($PLAYER_CHAR)
056D:   actor 7@ defined
05EE:   key_pressed 90 //VK_... Z
05EE:   key_pressed 50 //VK_... 2    //��ȥ�������� 
then
04C4: create_coordinate 3@ 4@ 5@ from_actor 7@ offset 0.0 1.2 0.0 
0055: put_player $PLAYER_CHAR at 3@ 4@ 5@
end

if and
Player.Defined($PLAYER_CHAR)
056D:   actor 8@ defined
05EE:   key_pressed 90 //VK_... Z
05EE:   key_pressed 51 //VK_... 3    //��ȥ�������� 
then
04C4: create_coordinate 3@ 4@ 5@ from_actor 8@ offset 0.0 1.2 0.0 
0055: put_player $PLAYER_CHAR at 3@ 4@ 5@
end

if and
Player.Defined($PLAYER_CHAR)
056D:   actor 11@ defined
05EE:   key_pressed 90 //VK_... Z
05EE:   key_pressed 52 //VK_... 4    //��ȥ�������� 
then
04C4: create_coordinate 3@ 4@ 5@ from_actor 11@ offset 0.0 1.2 0.0 
0055: put_player $PLAYER_CHAR at 3@ 4@ 5@
end



//delete all
if and
   Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 68 //VK_...  d 
05EE:   key_pressed 52 //VK_... 4
then 
wait 10
if  
056D:   actor 6@ defined
then
009B: destroy_actor_instantly  6@
end 
wait 10
if  
056D:   actor 7@ defined
then
009B: destroy_actor_instantly 7@
end 
wait 10
if  
056D:   actor 8@ defined
then
009B: destroy_actor_instantly 8@
end 
wait 10
if  
056D:   actor 11@ defined
then
009B: destroy_actor_instantly 11@
end 

end


//create one 
if and
   Player.Defined($PLAYER_CHAR)
05EE:   key_pressed 67 //VK_...  c 
05EE:   key_pressed 52 //VK_... 4
jf @CYSJ_1

0209: 9@ = random_int_in_ranges 0 12


if 
9@ == 1
then
023C: load_special_actor 1  'CHU1'
038B: load_requested_models 
10@++
03E5: text_box 'CHU1_'
end
if 
9@ == 2
then
023C: load_special_actor 1 'CHU3' 
038B: load_requested_models 
10@++
03E5: text_box 'CHU3_'
end
if 
9@ == 3
then
023C: load_special_actor 1   'CHU4'   
038B: load_requested_models 
10@++
03E5: text_box 'CHU4_'
end
if 
9@ == 4
then
023C: load_special_actor 1   'CHU5'
038B: load_requested_models 
10@++
03E5: text_box 'CHU5_'
end
if 
9@ == 5
then
023C: load_special_actor 1   'CHU6'
038B: load_requested_models 
10@++
03E5: text_box 'CHU6_'
end
if 
9@ == 6
then
023C: load_special_actor 1   'CHU7'
038B: load_requested_models 
10@++
03E5: text_box 'CHU7_'
end
if 
9@ == 7
then
023C: load_special_actor 1    'CHU8'
038B: load_requested_models 
10@++
03E5: text_box 'CHU8_'
end
if 
9@ == 8
then
023C: load_special_actor 1     'CHUY1'
038B: load_requested_models 
10@++
03E5: text_box 'CHUY1_'
end
if 
9@ == 9
then
023C: load_special_actor 1     'CHUY2'
038B: load_requested_models 
10@++
03E5: text_box 'CHUY2_'
end
if 
9@ == 10
then
023C: load_special_actor 1     'CHUY3'
038B: load_requested_models 
10@++
03E5: text_box 'CHUY3_'
end
if 
9@ == 11
then
023C: load_special_actor 1     'CHUY5' //CHUY4ģ���и�С覴�ûҪ 
038B: load_requested_models 
10@++
03E5: text_box 'CHUY5_'
end

if 10@ == 1
then
jump  @CYSJ_L1
end
if 10@ == 2
then 
jump  @CYSJ_L2
end
if 10@ ==3
then 
jump  @CYSJ_L3
end
if 10@ ==4
then
jump  @CYSJ_L4
end
if 10@ ==5
then
10@=1
jump  @CYSJ_L1
end


:CYSJ_L1
wait 0

if  
023D:   special_actor 1 loaded
jf @CYSJ_1

if  
056D:   actor 6@ defined
then
009B: destroy_actor_instantly 6@
end 
0470: 2@ = actor $PLAYER_ACTOR armed_weapon

04C4: create_coordinate 3@ 4@ 5@ from_actor $PLAYER_ACTOR offset 0.0 1.2 0.0 
Actor.Create(6@, 0, #SPECIAL01, 3@, 4@, 5@)    // player  0 civfemale 5 civmale 4
Actor.Health(6@) = 1000

02AB: set_actor 6@ immunities BP 1 FP 1 EP 1 CP 1 MP 1
01B2: give_actor 6@ weapon 33 ammo 99999 // Load the weapon model before using this 
//01B2: give_actor 6@ weapon 2@ ammo 9999
0243: set_actor 6@ ped_stats_to 30  //
0291: set_actor 6@ heed_threats 1
02A9: set_actor 6@ immune_to_nonplayer 1
02E2: set_actor 6@ weapon_accuracy_to 90
//0350: set_actor 6@ maintain_position_when_attacked 1
0319: set_actor 6@ running  1
//011A: set_actor 6@ search_threat 6    //��������     ���Կ�����֪��Ϊʲô��������뱾��pedtype�޹ء� 
011A: set_actor 6@ search_threat       24117232   //������       ���Կ�     ������������ֻ��һ��ֵ�������������ȷ�Ȳ�� 
//011A: set_actor 6@ search_threat 18   //�����ﷸ     ���Կ� 
//011A: set_actor 6@ search_threat 16   //�����Ȼ���Ա ���Կ� 
//011A: set_actor 6@ search_threat 17 //��������Ա   ���ܿ� 
//011A: set_actor 6@ search_threat 8    //�������ذ�   ���Կ� 
//011A: set_actor 6@ search_threat 7  //����cuBA��   ���ܿ�
//011A: set_actor 6@ search_threat 4    //������·��   ���Կ������������࣬����ɢ��ǹ����ɱ 
//011A: set_actor 6@ search_threat 5  //����Ů·��   ���ܿ� 
//011A: set_actor 6@ search_threat 11 //��������     ���ܿ� 

0296: unload_special_actor 1
 
wait 900 
jump @CYSJ_1



:CYSJ_L2
wait 0


if  
023D:   special_actor 1 loaded
jf @CYSJ_1
  


if
056D:   actor 7@ defined
then
009B: destroy_actor_instantly 7@
end 
0470: 2@ = actor $PLAYER_ACTOR armed_weapon

04C4: create_coordinate 3@ 4@ 5@ from_actor $PLAYER_ACTOR offset 0.0 1.2 0.0 
Actor.Create(7@, 0, #SPECIAL01, 3@, 4@, 5@)    //
Actor.Health(7@) = 1000

02AB: set_actor 7@ immunities BP 1 FP 1 EP 1 CP 1 MP 1
01B2: give_actor 7@ weapon 33 ammo 99999 // Load the weapon model before using this 
//01B2: give_actor 7@ weapon 2@ ammo 9999
0243: set_actor 7@ ped_stats_to 30  //golfer gang?
0291: set_actor 7@ heed_threats 1
02A9: set_actor 7@ immune_to_nonplayer 1
02E2: set_actor 7@ weapon_accuracy_to 90 
//0350: set_actor 7@ maintain_position_when_attacked 1
0319: set_actor 7@ running  1
//011A: set_actor 7@ search_threat 6    //��������     ���Կ�����֪��Ϊʲô��������뱾��pedtype�޹ء� 
011A: set_actor 7@ search_threat       24117232   //������       ���Կ� 
//011A: set_actor 7@ search_threat 18   //�����ﷸ     ���Կ� 
//011A: set_actor 7@ search_threat 16   //�����Ȼ���Ա ���Կ� 
//011A: set_actor 7@ search_threat 17 //��������Ա   ���ܿ� 
//011A: set_actor 7@ search_threat 8    //�������ذ�   ���Կ� 
//011A: set_actor 7@ search_threat 7  //����cuBA��   ���ܿ�
//011A: set_actor 7@ search_threat 4    //������·��   ���Կ������������࣬����ɢ��ǹ����ɱ 
//011A: set_actor 7@ search_threat 5  //����Ů·��   ���ܿ� 
//011A: set_actor 7@ search_threat 11 //��������     ���ܿ� 

0296: unload_special_actor 1 
wait 900 
jump @CYSJ_1

:CYSJ_L3
wait 0


if  
023D:   special_actor 1 loaded
jf @CYSJ_1
  


if
056D:   actor 8@ defined
then
009B: destroy_actor_instantly 8@
end 
0470: 2@ = actor $PLAYER_ACTOR armed_weapon

04C4: create_coordinate 3@ 4@ 5@ from_actor $PLAYER_ACTOR offset 0.0 1.2 0.0 
Actor.Create(8@, 0, #SPECIAL01, 3@, 4@, 5@)    //
Actor.Health(8@) = 1000

02AB: set_actor 8@ immunities BP 1 FP 1 EP 1 CP 1 MP 1
01B2: give_actor 8@ weapon 33 ammo 99999 // Load the weapon model before using this   
//01B2: give_actor 8@ weapon 2@ ammo 9999
0243: set_actor 8@ ped_stats_to 30  //golfer gang?
0291: set_actor 8@ heed_threats 1
02A9: set_actor 8@ immune_to_nonplayer 1
02E2: set_actor 8@ weapon_accuracy_to 90
//0350: set_actor 8@ maintain_position_when_attacked 1
0319: set_actor 8@ running  1
//011A: set_actor 8@ search_threat 6    //��������     ���Կ�����֪��Ϊʲô��������뱾��pedtype�޹ء� 
011A: set_actor 8@ search_threat       24117232   //������       ���Կ� 
//011A: set_actor 8@ search_threat 18   //�����ﷸ     ���Կ� 
//011A: set_actor 8@ search_threat 16   //�����Ȼ���Ա ���Կ� 
//011A: set_actor 8@ search_threat 17 //��������Ա   ���ܿ� 
//011A: set_actor 8@ search_threat 8    //�������ذ�   ���Կ� 
//011A: set_actor 8@ search_threat 7  //����cuBA��   ���ܿ�
//011A: set_actor 8@ search_threat 4    //������·��   ���Կ������������࣬����ɢ��ǹ����ɱ 
//011A: set_actor 8@ search_threat 5  //����Ů·��   ���ܿ� 
//011A: set_actor 8@ search_threat 11 //��������     ���ܿ� 

0296: unload_special_actor 1 
wait 900 
jump @CYSJ_1


:CYSJ_L4
wait 0


if  
023D:   special_actor 1 loaded
jf @CYSJ_1
  


if
056D:   actor 11@ defined
then
009B: destroy_actor_instantly 11@
end 
//0470: 2@ = actor $PLAYER_ACTOR armed_weapon
//Model.Load(#MINIGUN)
//038B: load_requested_models 
04C4: create_coordinate 3@ 4@ 5@ from_actor $PLAYER_ACTOR offset 0.0 1.2 0.0 
Actor.Create(11@, 0, #SPECIAL01, 3@, 4@, 5@)    //
Actor.Health(11@) = 1000

02AB: set_actor 11@ immunities BP 1 FP 1 EP 1 CP 1 MP 1
01B2: give_actor 11@ weapon 33 ammo 99999 // Load the weapon model before using this 
//01B2: give_actor 11@ weapon 2@ ammo 9999
0243: set_actor 11@ ped_stats_to 30  //golfer gang?
0291: set_actor 11@ heed_threats 1
02A9: set_actor 11@ immune_to_nonplayer 1
02E2: set_actor 11@ weapon_accuracy_to 90 
//0350: set_actor 11@ maintain_position_when_attacked 1
0319: set_actor 11@ running  1
//011A: set_actor 11@ search_threat 6    //��������     ���Կ�����֪��Ϊʲô��������뱾��pedtype�޹ء� 
011A: set_actor 11@ search_threat       24117232   //������       ���Կ� 
//011A: set_actor 11@ search_threat 18   //�����ﷸ     ���Կ� 
//011A: set_actor 11@ search_threat 16   //�����Ȼ���Ա ���Կ� 
//011A: set_actor 11@ search_threat 17 //��������Ա   ���ܿ� 
//011A: set_actor 11@ search_threat 8    //�������ذ�   ���Կ� 
//011A: set_actor 11@ search_threat 7  //����cuBA��   ���ܿ�
//011A: set_actor 11@ search_threat 4    //������·��   ���Կ������������࣬����ɢ��ǹ����ɱ 
//011A: set_actor 11@ search_threat 5  //����Ů·��   ���ܿ� 
//011A: set_actor 11@ search_threat 11 //��������     ���ܿ� 

0296: unload_special_actor 1 
wait 900 
jump @CYSJ_1

l  __SBFTR 