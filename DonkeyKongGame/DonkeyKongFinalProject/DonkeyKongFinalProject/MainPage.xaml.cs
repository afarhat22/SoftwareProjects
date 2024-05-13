using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Gaming.Input;
using DonkeyKongFinalProject.Assets;
using Windows.UI.Core;
using Windows.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DonkeyKongFinalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Stopwatch stopwatch;

        Platform ladder1;
        Platform ladder2;

        Platform bottomPlatform1;
        Platform bottomPlatform2;
        Platform bottomPlatform3;
        Platform bottomPlatform4;
        Platform bottomPlatform5;
        Platform bottomPlatform6;
        Platform bottomPlatform7;
        Platform bottomPlatform8;
        Platform bottomPlatform9;

        Platform layer2Platform1;
        Platform layer2Platform2;
        Platform layer2Platform3;
        Platform layer2Platform4;
        Platform layer2Platform5;
        Platform layer2Platform6;
        Platform layer2Platform7;
        Platform layer2Platform8;

        Platform layer3Platform1;
        Platform layer3Platform2;
        Platform layer3Platform3;
        Platform layer3Platform4;
        Platform layer3Platform5;
        Platform layer3Platform6;
        Platform layer3Platform7;
        Platform layer3Platform8;
        Platform layer3Platform9;

        Platform layer4Platform1;
        Platform layer4Platform2;
        Platform layer4Platform3;
        Platform layer4Platform4;
        Platform layer4Platform5;
        Platform layer4Platform6;
        Platform layer4Platform7;
        Platform layer4Platform8;
        Platform layer4Platform9;

        Vent vent1;
        Vent vent2;
        Vent vent3;
        Vent vent4;
        Vent vent5;
        Vent vent6;

        flyingLethal barrel1;
        flyingLethal barrel2;
        flyingLethal barrel3;
        flyingLethal barrel4;
        flyingLethal barrel5;
        flyingLethal barrel6;

        flyingLethal deathball1;
        flyingLethal deathball2;
        flyingLethal deathball3;
        flyingLethal deathball4;


   
        CanvasBitmap pinkCharacterImage;
        CanvasBitmap barrelImage;
        CanvasBitmap deathBallImage;
        
        Character pinkCharacter;
        Character character;


        List<IDrawable> drawables;
        List<ICollidable> platformCollidables;
        List<ILethals> lethals;

        List<Vent> vents;

        List<flyingLethal> barrels;
        List<flyingLethal> deathBalls;
        public MainPage()
        {
            this.InitializeComponent();

            stopwatch = new Stopwatch();
            stopwatch.Start();


            Window.Current.CoreWindow.KeyDown += Canvas_KeyDown;
            Window.Current.CoreWindow.KeyUp += Canvas_KeyUp;

            ladder1 = new Platform()
            {
                X = 830,
                Y = 375,
                Width = 20,
                Height = 70,
                color = Colors.Blue,
                brushWidth = 1

            };

            bottomPlatform1 = new Platform()
            {
                X = 0,
                Y = 450,

            };

            bottomPlatform2 = new Platform()
            {
                X = 100,
                Y = 450,

            };

            bottomPlatform3 = new Platform()
            {
                X = 200,
                Y = 450,
            };

            bottomPlatform4 = new Platform()
            {
                X = 300,
                Y = 450,
            };

            bottomPlatform5 = new Platform()
            {
                X = 400,
                Y = 450,
            };

            bottomPlatform6 = new Platform()
            {
                X = 500,
                Y = 450,
            };

            bottomPlatform7 = new Platform()
            {
                X = 600,
                Y = 450,
            };

            bottomPlatform8 = new Platform()
            {
                X = 700,
                Y = 450,
            };

            bottomPlatform9 = new Platform()
            {
                X = 800,
                Y = 450,
            };

            layer2Platform1 = new Platform()
            {
                X = 750,
                Y = 375,
            };

            layer2Platform2 = new Platform()
            {
                X = 650,
                Y = 365,
            };

            layer2Platform3 = new Platform()
            {
                X = 550,
                Y = 355,
            };

            layer2Platform4 = new Platform()
            {
                X = 420,
                Y = 345,
            };

            layer2Platform5 = new Platform()
            {
                X = 320,
                Y = 335,
            };

            layer2Platform6 = new Platform()
            {
                X = 220,
                Y = 325,
            };

            layer2Platform7 = new Platform()
            {
                X = 120,
                Y = 315,
            };

            layer2Platform8 = new Platform()
            {
                X = 0,
                Y = 265
            };

            layer3Platform9 = new Platform()
            {
                X = 50,
                Y = 220,
            };

            layer3Platform1 = new Platform()
            {
                X = 150,
                Y = 210
            };

            layer3Platform2 = new Platform()
            {
                X = 250,
                Y = 200
            };

            layer3Platform3 = new Platform()
            {
                X = 380,
                Y = 190,
            };

            layer3Platform4 = new Platform()
            {
                X = 1000,
                Y = 1000,
            };

            layer3Platform5 = new Platform()
            {
                X = 480,
                Y = 190,
            };

            layer3Platform6 = new Platform()
            {
                X = 580,
                Y = 190,
            };

            layer3Platform7 = new Platform()
            {
                X = 700,
                Y = 190,
            };

            layer3Platform8 = new Platform()
            {
                X = 800,
                Y = 190,
            };

            layer4Platform1 = new Platform()
            {
                X = 675,
                Y = 130
            };

            layer4Platform2 = new Platform()
            {
                X = 550,
                Y = 110
            };

            layer4Platform3 = new Platform()
            {
                X = 450,
                Y = 100
            };

            layer4Platform4 = new Platform()
            {
                X = 350,
                Y = 100,
            };

            layer4Platform5 = new Platform()
            {
                X = 250,
                Y = 100,
            };

            layer4Platform6 = new Platform()
            {
                X = 150,
                Y = 100
            };

            layer4Platform7 = new Platform()
            {
                X = 50,
                Y = 100
            };

            layer4Platform8 = new Platform()
            {
                X = 1000,
                Y = 1000
            };

            layer4Platform9 = new Platform()
            {
                X = 1000,
                Y = 1000
            };

            character = new Character()
            {
                X = 50,
                Y = 430,
                //X = 500,
                //Y = 100,
                width = 20,
                height = 20,
                isJumping = false,
                isDead = false
            };

            pinkCharacter = new Character()
            {
                X = 70,
                Y = 70,
                width = 20,
                height = 30
            };

            vent1 = new Vent()
            {
                X = layer3Platform6.X + layer3Platform6.Width / 2,
                height = 20,
                Y = layer3Platform6.Y - 10,
                width = 20,
                

            };

            vent6 = new Vent()
            {
                X = layer3Platform9.X + layer3Platform9.Width / 2,
                height = 20,
                Y = layer3Platform9.Y - 10,
                width = 20,


            };

            vent2 = new Vent()
            {
                X = bottomPlatform5.X + bottomPlatform5.Width / 2,
                height = 20,
                Y = bottomPlatform5.Y - 10,
                width = 20,
            };

            vent3 = new Vent()
            {
                X = layer2Platform6.X + layer2Platform6.Width / 2,
                height = 20,
                Y = layer2Platform6.Y - 10,
                width = 20,
            };

            vent4 = new Vent()
            {
                X = layer2Platform2.X + layer2Platform2.Width / 2,
                height = 20,
                Y = layer2Platform2.Y - 10,
                width = 20
            };

            vent5 = new Vent()
            {
                X = layer2Platform2.X + 10,
                height = 20,
                Y = layer2Platform2.Y - 10,
                width = 20,
            };

            barrel1 = new flyingLethal()
            {
                X = 110,
                Y = -950,
                width = 25,
                height = 25
            };

            barrel2 = new flyingLethal()
            {
                X = 775,
                Y = -150,
                width = 30,
                height = 30
            };

            barrel3 = new flyingLethal()
            {
                X = 500,
                Y = -400,
                width = 25,
                height = 25

            };

            barrel4 = new flyingLethal()
            {
                X = 280,
                Y = -600,
                width = 20,
                height = 20
            };

            barrel5 = new flyingLethal()
            {
                X = 400,
                Y = -800,
                width = 30,
                height = 30
            };

            barrel6 = new flyingLethal()
            {
                X = 600,
                Y = -1000,
                width = 25,
                height = 25

            };

            deathball1 = new flyingLethal()
            {
                X = -1200,
                Y = layer2Platform1.Y - 20,
                width = 15,
                height = 15
            };

            deathball2 = new flyingLethal()
            {
                X = -600,
                Y = layer4Platform6.Y - 20,
                width = 15,
                height = 15
            };

            deathball3 = new flyingLethal()
            {
                X = -200,
                Y = layer3Platform1.Y - 20,
                width = 15,
                height = 15
            };

            deathball4 = new flyingLethal()
            {
                X = -1000,
                Y = layer3Platform6.Y - 20,
                width = 15,
                height = 15

            };

            deathball4 = new flyingLethal()
            {
                X = -1000,
                Y = layer4Platform6.Y - 20,
                width = 15,
                height = 15

            };






            deathBalls = new List<flyingLethal> { deathball1, deathball2, deathball3, deathball4 };
            barrels = new List<flyingLethal>() { barrel1, barrel2, barrel3, barrel4, barrel5 };

            drawables = new List<IDrawable>() {bottomPlatform1, bottomPlatform2, bottomPlatform3, bottomPlatform4,
                bottomPlatform5, bottomPlatform6, bottomPlatform7, bottomPlatform8, bottomPlatform9,
            layer2Platform1, layer2Platform2, layer2Platform3, layer2Platform4, layer2Platform5, layer2Platform6, layer2Platform7, layer2Platform8,
            layer3Platform1, layer3Platform2, layer3Platform3, layer3Platform4, layer3Platform5, layer3Platform6, layer3Platform7, layer3Platform8, layer3Platform9,
            layer4Platform1, layer4Platform2, layer4Platform3, layer4Platform4, layer4Platform5, layer4Platform6, layer4Platform7, layer4Platform8, layer4Platform9, ladder1};

            platformCollidables = new List<ICollidable>() { bottomPlatform1, bottomPlatform2, bottomPlatform3, bottomPlatform4,
                bottomPlatform5, bottomPlatform6, bottomPlatform7, bottomPlatform8, bottomPlatform9,
            layer2Platform1, layer2Platform2, layer2Platform3, layer2Platform4, layer2Platform5, layer2Platform6, layer2Platform7, layer2Platform8,
            layer3Platform1, layer3Platform2, layer3Platform3, layer3Platform4, layer3Platform5, layer3Platform6, layer3Platform7, layer3Platform8, layer3Platform9,
            layer4Platform1, layer4Platform2, layer4Platform3, layer4Platform4, layer4Platform5, layer4Platform6, layer4Platform7, layer4Platform8, layer4Platform9, ladder1};

            vents = new List<Vent>() { vent1, vent2, vent3, vent4, vent5, vent6};

            lethals = new List<ILethals>()
            {
                
            };
            
            foreach (flyingLethal deathball in deathBalls)
            {
                lethals.Add(deathball);
            }
            foreach (flyingLethal barrel in barrels)
            {
                lethals.Add(barrel);
            }
            foreach (Vent vent in vents)
            {
                lethals.Add(vent);
                
            }
        }

        private void Canvas_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Left)
            {
                moveLeft();
            }
            else if (e.VirtualKey == Windows.System.VirtualKey.Right)
            {
                moveRight();
            } else if(e.VirtualKey == Windows.System.VirtualKey.Space)
            {
                doJump(character);
                
            }
        }

        private void Canvas_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Left)
            {
                character.goingLeft = false;
            }
            else if (e.VirtualKey == Windows.System.VirtualKey.Right)
            {
                character.goingRight = false;
            }
        }

        

        
        private void Canvas_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            foreach (IDrawable drawable in drawables)
            {
                drawable.Draw(args.DrawingSession);
            }

            args.DrawingSession.DrawImage(character.currentImage, new Rect(character.X, character.Y, character.width, character.height));
            args.DrawingSession.DrawImage(pinkCharacterImage, new Rect(pinkCharacter.X, pinkCharacter.Y, pinkCharacter.width, pinkCharacter.height));
            foreach (Vent vent in vents)
            {
                args.DrawingSession.DrawImage(vent.currentPhoto, new Rect(vent.X, vent.Y, vent.width, vent.height));
            }
            foreach (flyingLethal barrel in barrels)
            {
                args.DrawingSession.DrawImage(barrelImage, new Rect(barrel.X, barrel.Y, barrel.width, barrel.height));
            }
            foreach (flyingLethal deathball in deathBalls)
            {
                args.DrawingSession.DrawImage(deathBallImage, new Rect(deathball.X, deathball.Y, deathball.width, deathball.height));
            }
        }

        private void Canvas_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {
            if (!character.isDead)
            {
                updateCharacterMovemenet();
                updateCharacterMovementControllerVersion();
                updateVents();
                checkLethals();
                touchesPrincess();
                updateBarrels();
                updateDeathballs();
            }
        }

        private void updateDeathballs()
        {
            foreach (flyingLethal deathball in deathBalls)
            {
                deathball.X+=5;
                if (deathball.X > 1000) 
                {
                    deathball.X = -100;
                }
            }
        }

        private void updateBarrels()
        {
            foreach (flyingLethal barrel in barrels)
            {
                barrel.Y += 3;
                if (barrel.Y > 1100) 
                {
                    barrel.Y = -100;
                }
            }
        }

        private async void touchesPrincess()
        {
            if (!character.isDead && character.CheckCollision(pinkCharacter, out CollisionType type))
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
                {
                    character.isDead = true;
                    await WinDialog.ShowAsync();
                });
            }
        }
        
        private void updateCharacterMovemenet()
        {
            foreach (var collidable in platformCollidables)
            {
                if (character.CheckCollision(collidable, out CollisionType type))
                {
                    if (type == CollisionType.Bottom && !character.isJumping)
                    {
                        character.Y = collidable.getBounds().top - character.height;
                        character.isOnGround = true;
                    }
                }
                else if (type == CollisionType.None && !character.isJumping)
                {
                    character.Y += 0.25;
                }
            }

            if (character.goingLeft)
            {
                character.X -= 2;
            }
            else if (character.goingRight)
            {
                character.X += 2;
            }


            if (character.isJumping)
            {
                if (stopwatch.Elapsed.Milliseconds < 300)
                {
                    character.isOnGround = false;
                    character.Y -= 3;
                }
                else
                {
                    character.isJumping = false;
                    stopwatch.Stop();
                    stopwatch.Reset();
                }

                }
        }

        private void moveLeft()
        {
            character.goingLeft = true;
            character.currentImage = character.imageFacingLeft;
        }

        private void moveRight()
        {
            character.goingRight = true;
            character.currentImage = character.imageFacingRight;
        }

        private void doJump(Character character)
        {
            if (character.isOnGround)
            {
                stopwatch.Start();
                character.isJumping = true;
                character.isOnGround = false;
            }
        }

        private void updateCharacterMovementControllerVersion()
        {
            if (Gamepad.Gamepads.Count > 0)
            {
                Gamepad gamepad = Gamepad.Gamepads.First();
                var reading = gamepad.GetCurrentReading();
                if (reading.LeftThumbstickX < -0.5)
                {
                    moveLeft();
                } else if (reading.LeftThumbstickX > 0.5)
                {
                    moveRight();
                } else {
                    character.goingLeft = false;
                    character.goingRight = false;
                }

                if (reading.Buttons.HasFlag(GamepadButtons.A))
                {
                    doJump(character);
                }   
            }
        }

        private void updateVents()
        {
            foreach (Vent vent in vents)
            {
                vent.checkVentStatus();
            }
        }
        private void checkLethals()
        {
            foreach (ILethals lethal in lethals)
            {
                if (character.CheckCollision(lethal, out CollisionType type))
                {
                    if (type == CollisionType.Bottom && lethal.isActive())
                    {
                        characterDies();
                    }
                }
            }
        }


       private async void characterDies()
       {
            character.isDead = true;
            character.currentImage = character.deadCharacterImage;
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
           {
               await DeathDialog.ShowAsync();
           });
        }

        private void DeathDialog_MainMenuClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // Navigate to the main menu page
            Frame.Navigate(typeof(MenuPage));
        }
        private void DeathDialog_TryAgainClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void canvas_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Canvas_CreateResources(CanvasAnimatedControl sender, Microsoft.Graphics.Canvas.UI.CanvasCreateResourcesEventArgs args)
        {
            args.TrackAsyncAction(CreateResources(sender).AsAsyncAction());
        }

        async Task CreateResources(Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl sender)
        {
            character.imageFacingRight = await CanvasBitmap.LoadAsync(sender, "Assets/rightCharacter.png");
            character.imageFacingLeft = await CanvasBitmap.LoadAsync(sender, "Assets/leftCharacter.png");
            character.currentImage = character.imageFacingRight;
            character.deadCharacterImage = await CanvasBitmap.LoadAsync(sender, "Assets/deadCharacter.png");

            pinkCharacterImage = await CanvasBitmap.LoadAsync(sender, "Assets/pinkCharacter.png");

            barrelImage = await CanvasBitmap.LoadAsync(sender, "Assets/barrel.png");

            deathBallImage = await CanvasBitmap.LoadAsync(sender, "Assets/fireballImage.png");

            foreach (Vent vent in vents)
            {
                vent.inactiveImage = await CanvasBitmap.LoadAsync(sender, "Assets/inactiveVentPicture.png");
                vent.activeImage = await CanvasBitmap.LoadAsync(sender, "Assets/activeVentPicture.png");
                vent.currentPhoto = vent.inactiveImage;
            }

            



        }

        
    }
}
