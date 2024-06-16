
ducktab@ducktan:~/Desktop/NT209/Lab4$ objdump -d basic-reverse

basic-reverse:     file format elf32-i386


Disassembly of section .init:

080483d4 <_init>:
 80483d4:	53                   	push   %ebx
 80483d5:	83 ec 08             	sub    $0x8,%esp
 80483d8:	e8 03 01 00 00       	call   80484e0 <__x86.get_pc_thunk.bx>
 80483dd:	81 c3 23 2c 00 00    	add    $0x2c23,%ebx
 80483e3:	8b 83 fc ff ff ff    	mov    -0x4(%ebx),%eax
 80483e9:	85 c0                	test   %eax,%eax
 80483eb:	74 05                	je     80483f2 <_init+0x1e>
 80483ed:	e8 ae 00 00 00       	call   80484a0 <__gmon_start__@plt>
 80483f2:	83 c4 08             	add    $0x8,%esp
 80483f5:	5b                   	pop    %ebx
 80483f6:	c3                   	ret

Disassembly of section .plt:

08048400 <.plt>:
 8048400:	ff 35 04 b0 04 08    	push   0x804b004
 8048406:	ff 25 08 b0 04 08    	jmp    *0x804b008
 804840c:	00 00                	add    %al,(%eax)
	...

08048410 <strcmp@plt>:
 8048410:	ff 25 0c b0 04 08    	jmp    *0x804b00c
 8048416:	68 00 00 00 00       	push   $0x0
 804841b:	e9 e0 ff ff ff       	jmp    8048400 <.plt>

08048420 <printf@plt>:
 8048420:	ff 25 10 b0 04 08    	jmp    *0x804b010
 8048426:	68 08 00 00 00       	push   $0x8
 804842b:	e9 d0 ff ff ff       	jmp    8048400 <.plt>

08048430 <fflush@plt>:
 8048430:	ff 25 14 b0 04 08    	jmp    *0x804b014
 8048436:	68 10 00 00 00       	push   $0x10
 804843b:	e9 c0 ff ff ff       	jmp    8048400 <.plt>

08048440 <getchar@plt>:
 8048440:	ff 25 18 b0 04 08    	jmp    *0x804b018
 8048446:	68 18 00 00 00       	push   $0x18
 804844b:	e9 b0 ff ff ff       	jmp    8048400 <.plt>

08048450 <puts@plt>:
 8048450:	ff 25 1c b0 04 08    	jmp    *0x804b01c
 8048456:	68 20 00 00 00       	push   $0x20
 804845b:	e9 a0 ff ff ff       	jmp    8048400 <.plt>

08048460 <exit@plt>:
 8048460:	ff 25 20 b0 04 08    	jmp    *0x804b020
 8048466:	68 28 00 00 00       	push   $0x28
 804846b:	e9 90 ff ff ff       	jmp    8048400 <.plt>

08048470 <strlen@plt>:
 8048470:	ff 25 24 b0 04 08    	jmp    *0x804b024
 8048476:	68 30 00 00 00       	push   $0x30
 804847b:	e9 80 ff ff ff       	jmp    8048400 <.plt>

08048480 <__libc_start_main@plt>:
 8048480:	ff 25 28 b0 04 08    	jmp    *0x804b028
 8048486:	68 38 00 00 00       	push   $0x38
 804848b:	e9 70 ff ff ff       	jmp    8048400 <.plt>

08048490 <__isoc99_scanf@plt>:
 8048490:	ff 25 2c b0 04 08    	jmp    *0x804b02c
 8048496:	68 40 00 00 00       	push   $0x40
 804849b:	e9 60 ff ff ff       	jmp    8048400 <.plt>

Disassembly of section .plt.got:

080484a0 <__gmon_start__@plt>:
 80484a0:	ff 25 fc af 04 08    	jmp    *0x804affc
 80484a6:	66 90                	xchg   %ax,%ax

Disassembly of section .text:

080484b0 <_start>:
 80484b0:	31 ed                	xor    %ebp,%ebp
 80484b2:	5e                   	pop    %esi
 80484b3:	89 e1                	mov    %esp,%ecx
 80484b5:	83 e4 f0             	and    $0xfffffff0,%esp
 80484b8:	50                   	push   %eax
 80484b9:	54                   	push   %esp
 80484ba:	52                   	push   %edx
 80484bb:	68 20 8a 04 08       	push   $0x8048a20
 80484c0:	68 c0 89 04 08       	push   $0x80489c0
 80484c5:	51                   	push   %ecx
 80484c6:	56                   	push   %esi
 80484c7:	68 21 89 04 08       	push   $0x8048921
 80484cc:	e8 af ff ff ff       	call   8048480 <__libc_start_main@plt>
 80484d1:	f4                   	hlt
 80484d2:	66 90                	xchg   %ax,%ax
 80484d4:	66 90                	xchg   %ax,%ax
 80484d6:	66 90                	xchg   %ax,%ax
 80484d8:	66 90                	xchg   %ax,%ax
 80484da:	66 90                	xchg   %ax,%ax
 80484dc:	66 90                	xchg   %ax,%ax
 80484de:	66 90                	xchg   %ax,%ax

080484e0 <__x86.get_pc_thunk.bx>:
 80484e0:	8b 1c 24             	mov    (%esp),%ebx
 80484e3:	c3                   	ret
 80484e4:	66 90                	xchg   %ax,%ax
 80484e6:	66 90                	xchg   %ax,%ax
 80484e8:	66 90                	xchg   %ax,%ax
 80484ea:	66 90                	xchg   %ax,%ax
 80484ec:	66 90                	xchg   %ax,%ax
 80484ee:	66 90                	xchg   %ax,%ax

080484f0 <deregister_tm_clones>:
 80484f0:	b8 2b b1 04 08       	mov    $0x804b12b,%eax
 80484f5:	2d 28 b1 04 08       	sub    $0x804b128,%eax
 80484fa:	83 f8 06             	cmp    $0x6,%eax
 80484fd:	76 1a                	jbe    8048519 <deregister_tm_clones+0x29>
 80484ff:	b8 00 00 00 00       	mov    $0x0,%eax
 8048504:	85 c0                	test   %eax,%eax
 8048506:	74 11                	je     8048519 <deregister_tm_clones+0x29>
 8048508:	55                   	push   %ebp
 8048509:	89 e5                	mov    %esp,%ebp
 804850b:	83 ec 14             	sub    $0x14,%esp
 804850e:	68 28 b1 04 08       	push   $0x804b128
 8048513:	ff d0                	call   *%eax
 8048515:	83 c4 10             	add    $0x10,%esp
 8048518:	c9                   	leave
 8048519:	f3 c3                	repz ret
 804851b:	90                   	nop
 804851c:	8d 74 26 00          	lea    0x0(%esi,%eiz,1),%esi

08048520 <register_tm_clones>:
 8048520:	b8 28 b1 04 08       	mov    $0x804b128,%eax
 8048525:	2d 28 b1 04 08       	sub    $0x804b128,%eax
 804852a:	c1 f8 02             	sar    $0x2,%eax
 804852d:	89 c2                	mov    %eax,%edx
 804852f:	c1 ea 1f             	shr    $0x1f,%edx
 8048532:	01 d0                	add    %edx,%eax
 8048534:	d1 f8                	sar    %eax
 8048536:	74 1b                	je     8048553 <register_tm_clones+0x33>
 8048538:	ba 00 00 00 00       	mov    $0x0,%edx
 804853d:	85 d2                	test   %edx,%edx
 804853f:	74 12                	je     8048553 <register_tm_clones+0x33>
 8048541:	55                   	push   %ebp
 8048542:	89 e5                	mov    %esp,%ebp
 8048544:	83 ec 10             	sub    $0x10,%esp
 8048547:	50                   	push   %eax
 8048548:	68 28 b1 04 08       	push   $0x804b128
 804854d:	ff d2                	call   *%edx
 804854f:	83 c4 10             	add    $0x10,%esp
 8048552:	c9                   	leave
 8048553:	f3 c3                	repz ret
 8048555:	8d 74 26 00          	lea    0x0(%esi,%eiz,1),%esi
 8048559:	8d bc 27 00 00 00 00 	lea    0x0(%edi,%eiz,1),%edi

08048560 <__do_global_dtors_aux>:
 8048560:	80 3d 44 b1 04 08 00 	cmpb   $0x0,0x804b144
 8048567:	75 13                	jne    804857c <__do_global_dtors_aux+0x1c>
 8048569:	55                   	push   %ebp
 804856a:	89 e5                	mov    %esp,%ebp
 804856c:	83 ec 08             	sub    $0x8,%esp
 804856f:	e8 7c ff ff ff       	call   80484f0 <deregister_tm_clones>
 8048574:	c6 05 44 b1 04 08 01 	movb   $0x1,0x804b144
 804857b:	c9                   	leave
 804857c:	f3 c3                	repz ret
 804857e:	66 90                	xchg   %ax,%ax

08048580 <frame_dummy>:
 8048580:	b8 10 af 04 08       	mov    $0x804af10,%eax
 8048585:	8b 10                	mov    (%eax),%edx
 8048587:	85 d2                	test   %edx,%edx
 8048589:	75 05                	jne    8048590 <frame_dummy+0x10>
 804858b:	eb 93                	jmp    8048520 <register_tm_clones>
 804858d:	8d 76 00             	lea    0x0(%esi),%esi
 8048590:	ba 00 00 00 00       	mov    $0x0,%edx
 8048595:	85 d2                	test   %edx,%edx
 8048597:	74 f2                	je     804858b <frame_dummy+0xb>
 8048599:	55                   	push   %ebp
 804859a:	89 e5                	mov    %esp,%ebp
 804859c:	83 ec 14             	sub    $0x14,%esp
 804859f:	50                   	push   %eax
 80485a0:	ff d2                	call   *%edx
 80485a2:	83 c4 10             	add    $0x10,%esp
 80485a5:	c9                   	leave
 80485a6:	e9 75 ff ff ff       	jmp    8048520 <register_tm_clones>

080485ab <funny_func>:
 80485ab:	55                   	push   %ebp
 80485ac:	89 e5                	mov    %esp,%ebp
 80485ae:	83 ec 10             	sub    $0x10,%esp
 80485b1:	c7 45 fc 00 00 00 00 	movl   $0x0,-0x4(%ebp)
 80485b8:	8b 55 08             	mov    0x8(%ebp),%edx
 80485bb:	8b 45 0c             	mov    0xc(%ebp),%eax
 80485be:	01 d0                	add    %edx,%eax
 80485c0:	8d 48 ff             	lea    -0x1(%eax),%ecx
 80485c3:	8b 55 08             	mov    0x8(%ebp),%edx
 80485c6:	8b 45 0c             	mov    0xc(%ebp),%eax
 80485c9:	01 d0                	add    %edx,%eax
 80485cb:	0f af c1             	imul   %ecx,%eax
 80485ce:	89 45 fc             	mov    %eax,-0x4(%ebp)
 80485d1:	8b 45 fc             	mov    -0x4(%ebp),%eax
 80485d4:	c9                   	leave
 80485d5:	c3                   	ret

080485d6 <is_equal>:
 80485d6:	55                   	push   %ebp
 80485d7:	89 e5                	mov    %esp,%ebp
 80485d9:	83 ec 08             	sub    $0x8,%esp
 80485dc:	83 ec 08             	sub    $0x8,%esp
 80485df:	ff 75 0c             	push   0xc(%ebp)
 80485e2:	ff 75 08             	push   0x8(%ebp)
 80485e5:	e8 26 fe ff ff       	call   8048410 <strcmp@plt>
 80485ea:	83 c4 10             	add    $0x10,%esp
 80485ed:	85 c0                	test   %eax,%eax
 80485ef:	0f 94 c0             	sete   %al
 80485f2:	0f b6 c0             	movzbl %al,%eax
 80485f5:	c9                   	leave
 80485f6:	c3                   	ret

080485f7 <success_1>:
 80485f7:	55                   	push   %ebp
 80485f8:	89 e5                	mov    %esp,%ebp
 80485fa:	83 ec 08             	sub    $0x8,%esp
 80485fd:	83 ec 0c             	sub    $0xc,%esp
 8048600:	68 74 90 04 08       	push   $0x8049074
 8048605:	e8 46 fe ff ff       	call   8048450 <puts@plt>
 804860a:	83 c4 10             	add    $0x10,%esp
 804860d:	90                   	nop
 804860e:	c9                   	leave
 804860f:	c3                   	ret

08048610 <success_2>:
 8048610:	55                   	push   %ebp
 8048611:	89 e5                	mov    %esp,%ebp
 8048613:	83 ec 08             	sub    $0x8,%esp
 8048616:	83 ec 0c             	sub    $0xc,%esp
 8048619:	68 ac 90 04 08       	push   $0x80490ac
 804861e:	e8 2d fe ff ff       	call   8048450 <puts@plt>
 8048623:	83 c4 10             	add    $0x10,%esp
 8048626:	90                   	nop
 8048627:	c9                   	leave
 8048628:	c3                   	ret

08048629 <success_3>:
 8048629:	55                   	push   %ebp
 804862a:	89 e5                	mov    %esp,%ebp
 804862c:	83 ec 08             	sub    $0x8,%esp
 804862f:	83 ec 0c             	sub    $0xc,%esp
 8048632:	68 e0 90 04 08       	push   $0x80490e0
 8048637:	e8 14 fe ff ff       	call   8048450 <puts@plt>
 804863c:	83 c4 10             	add    $0x10,%esp
 804863f:	90                   	nop
 8048640:	c9                   	leave
 8048641:	c3                   	ret

08048642 <failed>:
 8048642:	55                   	push   %ebp
 8048643:	89 e5                	mov    %esp,%ebp
 8048645:	83 ec 08             	sub    $0x8,%esp
 8048648:	83 ec 0c             	sub    $0xc,%esp
 804864b:	68 18 91 04 08       	push   $0x8049118
 8048650:	e8 fb fd ff ff       	call   8048450 <puts@plt>
 8048655:	83 c4 10             	add    $0x10,%esp
 8048658:	90                   	nop
 8048659:	c9                   	leave
 804865a:	c3                   	ret

0804865b <hardCode>:
 804865b:	55                   	push   %ebp
 804865c:	89 e5                	mov    %esp,%ebp
 804865e:	81 ec f8 03 00 00    	sub    $0x3f8,%esp
 8048664:	e8 d7 fd ff ff       	call   8048440 <getchar@plt>
 8048669:	83 ec 0c             	sub    $0xc,%esp
 804866c:	68 40 91 04 08       	push   $0x8049140
 8048671:	e8 da fd ff ff       	call   8048450 <puts@plt>
 8048676:	83 c4 10             	add    $0x10,%esp
 8048679:	83 ec 08             	sub    $0x8,%esp
 804867c:	8d 85 10 fc ff ff    	lea    -0x3f0(%ebp),%eax
 8048682:	50                   	push   %eax
 8048683:	68 6a 91 04 08       	push   $0x804916a
 8048688:	e8 03 fe ff ff       	call   8048490 <__isoc99_scanf@plt>
 804868d:	83 c4 10             	add    $0x10,%esp
 8048690:	83 ec 08             	sub    $0x8,%esp
 8048693:	8d 85 10 fc ff ff    	lea    -0x3f0(%ebp),%eax
 8048699:	50                   	push   %eax
 804869a:	68 70 91 04 08       	push   $0x8049170
 804869f:	e8 7c fd ff ff       	call   8048420 <printf@plt>
 80486a4:	83 c4 10             	add    $0x10,%esp
 80486a7:	83 ec 08             	sub    $0x8,%esp
 80486aa:	68 53 8b 04 08       	push   $0x8048b53
 80486af:	8d 85 10 fc ff ff    	lea    -0x3f0(%ebp),%eax
 80486b5:	50                   	push   %eax
 80486b6:	e8 55 fd ff ff       	call   8048410 <strcmp@plt>
 80486bb:	83 c4 10             	add    $0x10,%esp
 80486be:	85 c0                	test   %eax,%eax
 80486c0:	75 07                	jne    80486c9 <hardCode+0x6e>
 80486c2:	e8 30 ff ff ff       	call   80485f7 <success_1>
 80486c7:	eb 05                	jmp    80486ce <hardCode+0x73>
 80486c9:	e8 74 ff ff ff       	call   8048642 <failed>
 80486ce:	90                   	nop
 80486cf:	c9                   	leave
 80486d0:	c3                   	ret

080486d1 <otherhardCode>:
 80486d1:	55                   	push   %ebp
 80486d2:	89 e5                	mov    %esp,%ebp
 80486d4:	83 ec 18             	sub    $0x18,%esp
 80486d7:	e8 64 fd ff ff       	call   8048440 <getchar@plt>
 80486dc:	83 ec 0c             	sub    $0xc,%esp
 80486df:	68 94 91 04 08       	push   $0x8049194
 80486e4:	e8 67 fd ff ff       	call   8048450 <puts@plt>
 80486e9:	83 c4 10             	add    $0x10,%esp
 80486ec:	83 ec 04             	sub    $0x4,%esp
 80486ef:	8d 45 ec             	lea    -0x14(%ebp),%eax
 80486f2:	50                   	push   %eax
 80486f3:	8d 45 f0             	lea    -0x10(%ebp),%eax
 80486f6:	50                   	push   %eax
 80486f7:	68 ca 91 04 08       	push   $0x80491ca
 80486fc:	e8 8f fd ff ff       	call   8048490 <__isoc99_scanf@plt>
 8048701:	83 c4 10             	add    $0x10,%esp
 8048704:	8b 55 ec             	mov    -0x14(%ebp),%edx
 8048707:	8b 45 f0             	mov    -0x10(%ebp),%eax
 804870a:	83 ec 04             	sub    $0x4,%esp
 804870d:	52                   	push   %edx
 804870e:	50                   	push   %eax
 804870f:	68 d0 91 04 08       	push   $0x80491d0
 8048714:	e8 07 fd ff ff       	call   8048420 <printf@plt>
 8048719:	83 c4 10             	add    $0x10,%esp
 804871c:	c7 45 f4 04 00 00 00 	movl   $0x4,-0xc(%ebp)
 8048723:	8b 45 f0             	mov    -0x10(%ebp),%eax
 8048726:	3b 45 f4             	cmp    -0xc(%ebp),%eax
 8048729:	75 31                	jne    804875c <otherhardCode+0x8b>
 804872b:	8b 55 f0             	mov    -0x10(%ebp),%edx
 804872e:	8b 45 f0             	mov    -0x10(%ebp),%eax
 8048731:	8b 04 85 60 8a 04 08 	mov    0x8048a60(,%eax,4),%eax
 8048738:	83 ec 08             	sub    $0x8,%esp
 804873b:	52                   	push   %edx
 804873c:	50                   	push   %eax
 804873d:	e8 69 fe ff ff       	call   80485ab <funny_func>
 8048742:	83 c4 10             	add    $0x10,%esp
 8048745:	89 c2                	mov    %eax,%edx
 8048747:	8b 45 ec             	mov    -0x14(%ebp),%eax
 804874a:	39 c2                	cmp    %eax,%edx
 804874c:	75 07                	jne    8048755 <otherhardCode+0x84>
 804874e:	e8 bd fe ff ff       	call   8048610 <success_2>
 8048753:	eb 0c                	jmp    8048761 <otherhardCode+0x90>
 8048755:	e8 e8 fe ff ff       	call   8048642 <failed>
 804875a:	eb 05                	jmp    8048761 <otherhardCode+0x90>
 804875c:	e8 e1 fe ff ff       	call   8048642 <failed>
 8048761:	90                   	nop
 8048762:	c9                   	leave
 8048763:	c3                   	ret

08048764 <userpass>:
 8048764:	55                   	push   %ebp
 8048765:	89 e5                	mov    %esp,%ebp
 8048767:	53                   	push   %ebx
 8048768:	83 ec 34             	sub    $0x34,%esp
 804876b:	c6 45 ef 66          	movb   $0x66,-0x11(%ebp)
 804876f:	c6 45 f0 60          	movb   $0x60,-0x10(%ebp)
 8048773:	c6 45 f1 6c          	movb   $0x6c,-0xf(%ebp)
 8048777:	c6 45 f2 72          	movb   $0x72,-0xe(%ebp)
 804877b:	c6 45 f3 5a          	movb   $0x5a,-0xd(%ebp)
 804877f:	e8 bc fc ff ff       	call   8048440 <getchar@plt>
 8048784:	83 ec 0c             	sub    $0xc,%esp
 8048787:	68 e3 91 04 08       	push   $0x80491e3
 804878c:	e8 bf fc ff ff       	call   8048450 <puts@plt>
 8048791:	83 c4 10             	add    $0x10,%esp
 8048794:	83 ec 08             	sub    $0x8,%esp
 8048797:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 804879a:	50                   	push   %eax
 804879b:	68 6a 91 04 08       	push   $0x804916a
 80487a0:	e8 eb fc ff ff       	call   8048490 <__isoc99_scanf@plt>
 80487a5:	83 c4 10             	add    $0x10,%esp
 80487a8:	e8 93 fc ff ff       	call   8048440 <getchar@plt>
 80487ad:	83 ec 0c             	sub    $0xc,%esp
 80487b0:	68 f8 91 04 08       	push   $0x80491f8
 80487b5:	e8 96 fc ff ff       	call   8048450 <puts@plt>
 80487ba:	83 c4 10             	add    $0x10,%esp
 80487bd:	83 ec 08             	sub    $0x8,%esp
 80487c0:	8d 45 db             	lea    -0x25(%ebp),%eax
 80487c3:	50                   	push   %eax
 80487c4:	68 6a 91 04 08       	push   $0x804916a
 80487c9:	e8 c2 fc ff ff       	call   8048490 <__isoc99_scanf@plt>
 80487ce:	83 c4 10             	add    $0x10,%esp
 80487d1:	83 ec 04             	sub    $0x4,%esp
 80487d4:	8d 45 db             	lea    -0x25(%ebp),%eax
 80487d7:	50                   	push   %eax
 80487d8:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 80487db:	50                   	push   %eax
 80487dc:	68 10 92 04 08       	push   $0x8049210
 80487e1:	e8 3a fc ff ff       	call   8048420 <printf@plt>
 80487e6:	83 c4 10             	add    $0x10,%esp
 80487e9:	83 ec 0c             	sub    $0xc,%esp
 80487ec:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 80487ef:	50                   	push   %eax
 80487f0:	e8 7b fc ff ff       	call   8048470 <strlen@plt>
 80487f5:	83 c4 10             	add    $0x10,%esp
 80487f8:	83 f8 09             	cmp    $0x9,%eax
 80487fb:	75 24                	jne    8048821 <userpass+0xbd>
 80487fd:	83 ec 0c             	sub    $0xc,%esp
 8048800:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 8048803:	50                   	push   %eax
 8048804:	e8 67 fc ff ff       	call   8048470 <strlen@plt>
 8048809:	83 c4 10             	add    $0x10,%esp
 804880c:	89 c3                	mov    %eax,%ebx
 804880e:	83 ec 0c             	sub    $0xc,%esp
 8048811:	8d 45 db             	lea    -0x25(%ebp),%eax
 8048814:	50                   	push   %eax
 8048815:	e8 56 fc ff ff       	call   8048470 <strlen@plt>
 804881a:	83 c4 10             	add    $0x10,%esp
 804881d:	39 c3                	cmp    %eax,%ebx
 804881f:	74 0a                	je     804882b <userpass+0xc7>
 8048821:	e8 1c fe ff ff       	call   8048642 <failed>
 8048826:	e9 f0 00 00 00       	jmp    804891b <userpass+0x1b7>
 804882b:	c7 45 f4 00 00 00 00 	movl   $0x0,-0xc(%ebp)
 8048832:	c7 45 f4 00 00 00 00 	movl   $0x0,-0xc(%ebp)
 8048839:	eb 53                	jmp    804888e <userpass+0x12a>
 804883b:	83 7d f4 01          	cmpl   $0x1,-0xc(%ebp)
 804883f:	7f 17                	jg     8048858 <userpass+0xf4>
 8048841:	8b 45 f4             	mov    -0xc(%ebp),%eax
 8048844:	83 c0 02             	add    $0x2,%eax
 8048847:	0f b6 44 05 e5       	movzbl -0x1b(%ebp,%eax,1),%eax
 804884c:	8d 4d d2             	lea    -0x2e(%ebp),%ecx
 804884f:	8b 55 f4             	mov    -0xc(%ebp),%edx
 8048852:	01 ca                	add    %ecx,%edx
 8048854:	88 02                	mov    %al,(%edx)
 8048856:	eb 32                	jmp    804888a <userpass+0x126>
 8048858:	83 7d f4 03          	cmpl   $0x3,-0xc(%ebp)
 804885c:	7f 17                	jg     8048875 <userpass+0x111>
 804885e:	8b 45 f4             	mov    -0xc(%ebp),%eax
 8048861:	83 c0 05             	add    $0x5,%eax
 8048864:	0f b6 44 05 e5       	movzbl -0x1b(%ebp,%eax,1),%eax
 8048869:	8d 4d d2             	lea    -0x2e(%ebp),%ecx
 804886c:	8b 55 f4             	mov    -0xc(%ebp),%edx
 804886f:	01 ca                	add    %ecx,%edx
 8048871:	88 02                	mov    %al,(%edx)
 8048873:	eb 15                	jmp    804888a <userpass+0x126>
 8048875:	8b 45 f4             	mov    -0xc(%ebp),%eax
 8048878:	83 e8 04             	sub    $0x4,%eax
 804887b:	0f b6 44 05 ef       	movzbl -0x11(%ebp,%eax,1),%eax
 8048880:	8d 4d d2             	lea    -0x2e(%ebp),%ecx
 8048883:	8b 55 f4             	mov    -0xc(%ebp),%edx
 8048886:	01 ca                	add    %ecx,%edx
 8048888:	88 02                	mov    %al,(%edx)
 804888a:	83 45 f4 01          	addl   $0x1,-0xc(%ebp)
 804888e:	83 7d f4 08          	cmpl   $0x8,-0xc(%ebp)
 8048892:	7e a7                	jle    804883b <userpass+0xd7>
 8048894:	c7 45 f4 00 00 00 00 	movl   $0x0,-0xc(%ebp)
 804889b:	eb 3f                	jmp    80488dc <userpass+0x178>
 804889d:	8d 55 e5             	lea    -0x1b(%ebp),%edx
 80488a0:	8b 45 f4             	mov    -0xc(%ebp),%eax
 80488a3:	01 d0                	add    %edx,%eax
 80488a5:	0f b6 00             	movzbl (%eax),%eax
 80488a8:	0f be d0             	movsbl %al,%edx
 80488ab:	8d 4d d2             	lea    -0x2e(%ebp),%ecx
 80488ae:	8b 45 f4             	mov    -0xc(%ebp),%eax
 80488b1:	01 c8                	add    %ecx,%eax
 80488b3:	0f b6 00             	movzbl (%eax),%eax
 80488b6:	0f be c0             	movsbl %al,%eax
 80488b9:	01 d0                	add    %edx,%eax
 80488bb:	89 c2                	mov    %eax,%edx
 80488bd:	c1 ea 1f             	shr    $0x1f,%edx
 80488c0:	01 d0                	add    %edx,%eax
 80488c2:	d1 f8                	sar    %eax
 80488c4:	89 c1                	mov    %eax,%ecx
 80488c6:	8d 55 db             	lea    -0x25(%ebp),%edx
 80488c9:	8b 45 f4             	mov    -0xc(%ebp),%eax
 80488cc:	01 d0                	add    %edx,%eax
 80488ce:	0f b6 00             	movzbl (%eax),%eax
 80488d1:	0f be c0             	movsbl %al,%eax
 80488d4:	39 c1                	cmp    %eax,%ecx
 80488d6:	75 1e                	jne    80488f6 <userpass+0x192>
 80488d8:	83 45 f4 01          	addl   $0x1,-0xc(%ebp)
 80488dc:	83 ec 0c             	sub    $0xc,%esp
 80488df:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 80488e2:	50                   	push   %eax
 80488e3:	e8 88 fb ff ff       	call   8048470 <strlen@plt>
 80488e8:	83 c4 10             	add    $0x10,%esp
 80488eb:	89 c2                	mov    %eax,%edx
 80488ed:	8b 45 f4             	mov    -0xc(%ebp),%eax
 80488f0:	39 c2                	cmp    %eax,%edx
 80488f2:	77 a9                	ja     804889d <userpass+0x139>
 80488f4:	eb 01                	jmp    80488f7 <userpass+0x193>
 80488f6:	90                   	nop
 80488f7:	83 ec 0c             	sub    $0xc,%esp
 80488fa:	8d 45 e5             	lea    -0x1b(%ebp),%eax
 80488fd:	50                   	push   %eax
 80488fe:	e8 6d fb ff ff       	call   8048470 <strlen@plt>
 8048903:	83 c4 10             	add    $0x10,%esp
 8048906:	89 c2                	mov    %eax,%edx
 8048908:	8b 45 f4             	mov    -0xc(%ebp),%eax
 804890b:	39 c2                	cmp    %eax,%edx
 804890d:	75 07                	jne    8048916 <userpass+0x1b2>
 804890f:	e8 15 fd ff ff       	call   8048629 <success_3>
 8048914:	eb 05                	jmp    804891b <userpass+0x1b7>
 8048916:	e8 27 fd ff ff       	call   8048642 <failed>
 804891b:	90                   	nop
 804891c:	8b 5d fc             	mov    -0x4(%ebp),%ebx
 804891f:	c9                   	leave
 8048920:	c3                   	ret

08048921 <main>:
 8048921:	8d 4c 24 04          	lea    0x4(%esp),%ecx
 8048925:	83 e4 f0             	and    $0xfffffff0,%esp
 8048928:	ff 71 fc             	push   -0x4(%ecx)
 804892b:	55                   	push   %ebp
 804892c:	89 e5                	mov    %esp,%ebp
 804892e:	51                   	push   %ecx
 804892f:	83 ec 14             	sub    $0x14,%esp
 8048932:	83 ec 0c             	sub    $0xc,%esp
 8048935:	68 3c 92 04 08       	push   $0x804923c
 804893a:	e8 e1 fa ff ff       	call   8048420 <printf@plt>
 804893f:	83 c4 10             	add    $0x10,%esp
 8048942:	83 ec 08             	sub    $0x8,%esp
 8048945:	8d 45 ec             	lea    -0x14(%ebp),%eax
 8048948:	50                   	push   %eax
 8048949:	68 b5 92 04 08       	push   $0x80492b5
 804894e:	e8 3d fb ff ff       	call   8048490 <__isoc99_scanf@plt>
 8048953:	83 c4 10             	add    $0x10,%esp
 8048956:	a1 40 b1 04 08       	mov    0x804b140,%eax
 804895b:	83 ec 0c             	sub    $0xc,%esp
 804895e:	50                   	push   %eax
 804895f:	e8 cc fa ff ff       	call   8048430 <fflush@plt>
 8048964:	83 c4 10             	add    $0x10,%esp
 8048967:	8b 45 ec             	mov    -0x14(%ebp),%eax
 804896a:	83 f8 01             	cmp    $0x1,%eax
 804896d:	75 07                	jne    8048976 <main+0x55>
 804896f:	e8 e7 fc ff ff       	call   804865b <hardCode>
 8048974:	eb 38                	jmp    80489ae <main+0x8d>
 8048976:	8b 45 ec             	mov    -0x14(%ebp),%eax
 8048979:	83 f8 02             	cmp    $0x2,%eax
 804897c:	75 07                	jne    8048985 <main+0x64>
 804897e:	e8 4e fd ff ff       	call   80486d1 <otherhardCode>
 8048983:	eb 29                	jmp    80489ae <main+0x8d>
 8048985:	8b 45 ec             	mov    -0x14(%ebp),%eax
 8048988:	83 f8 03             	cmp    $0x3,%eax
 804898b:	75 07                	jne    8048994 <main+0x73>
 804898d:	e8 d2 fd ff ff       	call   8048764 <userpass>
 8048992:	eb 1a                	jmp    80489ae <main+0x8d>
 8048994:	83 ec 0c             	sub    $0xc,%esp
 8048997:	68 b8 92 04 08       	push   $0x80492b8
 804899c:	e8 af fa ff ff       	call   8048450 <puts@plt>
 80489a1:	83 c4 10             	add    $0x10,%esp
 80489a4:	83 ec 0c             	sub    $0xc,%esp
 80489a7:	6a 00                	push   $0x0
 80489a9:	e8 b2 fa ff ff       	call   8048460 <exit@plt>
 80489ae:	b8 00 00 00 00       	mov    $0x0,%eax
 80489b3:	8b 4d fc             	mov    -0x4(%ebp),%ecx
 80489b6:	c9                   	leave
 80489b7:	8d 61 fc             	lea    -0x4(%ecx),%esp
 80489ba:	c3                   	ret
 80489bb:	66 90                	xchg   %ax,%ax
 80489bd:	66 90                	xchg   %ax,%ax
 80489bf:	90                   	nop

080489c0 <__libc_csu_init>:
 80489c0:	55                   	push   %ebp
 80489c1:	57                   	push   %edi
 80489c2:	56                   	push   %esi
 80489c3:	53                   	push   %ebx
 80489c4:	e8 17 fb ff ff       	call   80484e0 <__x86.get_pc_thunk.bx>
 80489c9:	81 c3 37 26 00 00    	add    $0x2637,%ebx
 80489cf:	83 ec 0c             	sub    $0xc,%esp
 80489d2:	8b 6c 24 20          	mov    0x20(%esp),%ebp
 80489d6:	8d b3 0c ff ff ff    	lea    -0xf4(%ebx),%esi
 80489dc:	e8 f3 f9 ff ff       	call   80483d4 <_init>
 80489e1:	8d 83 08 ff ff ff    	lea    -0xf8(%ebx),%eax
 80489e7:	29 c6                	sub    %eax,%esi
 80489e9:	c1 fe 02             	sar    $0x2,%esi
 80489ec:	85 f6                	test   %esi,%esi
 80489ee:	74 25                	je     8048a15 <__libc_csu_init+0x55>
 80489f0:	31 ff                	xor    %edi,%edi
 80489f2:	8d b6 00 00 00 00    	lea    0x0(%esi),%esi
 80489f8:	83 ec 04             	sub    $0x4,%esp
 80489fb:	ff 74 24 2c          	push   0x2c(%esp)
 80489ff:	ff 74 24 2c          	push   0x2c(%esp)
 8048a03:	55                   	push   %ebp
 8048a04:	ff 94 bb 08 ff ff ff 	call   *-0xf8(%ebx,%edi,4)
 8048a0b:	83 c7 01             	add    $0x1,%edi
 8048a0e:	83 c4 10             	add    $0x10,%esp
 8048a11:	39 f7                	cmp    %esi,%edi
 8048a13:	75 e3                	jne    80489f8 <__libc_csu_init+0x38>
 8048a15:	83 c4 0c             	add    $0xc,%esp
 8048a18:	5b                   	pop    %ebx
 8048a19:	5e                   	pop    %esi
 8048a1a:	5f                   	pop    %edi
 8048a1b:	5d                   	pop    %ebp
 8048a1c:	c3                   	ret
 8048a1d:	8d 76 00             	lea    0x0(%esi),%esi

08048a20 <__libc_csu_fini>:
 8048a20:	f3 c3                	repz ret

Disassembly of section .fini:

08048a24 <_fini>:
 8048a24:	53                   	push   %ebx
 8048a25:	83 ec 08             	sub    $0x8,%esp
 8048a28:	e8 b3 fa ff ff       	call   80484e0 <__x86.get_pc_thunk.bx>
 8048a2d:	81 c3 d3 25 00 00    	add    $0x25d3,%ebx
 8048a33:	83 c4 08             	add    $0x8,%esp
 8048a36:	5b                   	pop    %ebx
 8048a37:	c3                   	ret
ducktab@ducktan:~/Desktop/NT209/Lab4$ 
