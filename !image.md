## <a href="https://github.com/Hidekithiago/Automacao/blob/master/README.md">Image</a> <br>
<details>
<details><summary><b>Comparar imagem</b></summary>
  
####  NuGet
  > System.Drawing.Common
  
####  import
  > using System.Drawing;
  ><br>using System.Drawing.Imaging;
  
####  Code  
  > private static void comparatorImage(String urlImg1, String urlImg2)
  ><br>      {
  ><br>            string img1_ref, img2_ref;
  ><br>            Bitmap img1 = new Bitmap(urlImg1);
  ><br>            Bitmap img2 = new Bitmap(urlImg2);
  ><br>            var flag=true;
  ><br>
  ><br>
  ><br>            if (img1.Width == img2.Width && img1.Height == img2.Height)
  ><br>            {
  ><br>                for (int i = 0; i < img1.Width; i++)
  ><br>                {
  ><br>                    for (int j = 0; j < img1.Height; j++)
  ><br>                    {
  ><br>                        img1_ref = img1.GetPixel(i, j).ToString();
  ><br>                        img2_ref = img2.GetPixel(i, j).ToString();
  ><br>                        if (img1_ref != img2_ref)
  ><br>                        {                            
  ><br>                            flag = false;
  ><br>                            break;
  ><br>                        }
  ><br>                    }
  ><br>                }
  ><br>                Console.WriteLine(flag);
  ><br>            }
  ><br>            else
  ><br>            {                
  ><br>            }
  ><br>        }
  
</details>
<details><summary><b>Comparar imagem e executar algo</b></summary>
  
####  NuGet
  > System.Drawing.Common
  
####  import
  > using System.Drawing;
  ><br>using System.Drawing.Imaging;
  
####  Code  
  > k = 0;
  ><br>              do{// Mensagem de Pedido nao encontrado
  ><br>                    imgIgual = false;
  ><br>                    Thread.Sleep(500);
  ><br>                    PrintScreen(365, 152, 0, 0, 635, 420);
  ><br>                    dirPrintModelo = @"C:\quaestum\img\modeloPedidoKPL.jpg";
  ><br>                    imgIgual = ComparatorImage(dirPrintModelo, dirPrint);
  ><br>             if (k < 9)
  ><br>                    {
  ><br>                        k++;
  ><br>                        if (imgIgual == true)
  ><br>                        {
  ><br>                            MouseClick(742, 441);
  ><br>                            MouseClick(1355, 31);
  ><br>                            Console.WriteLine("1355");
  ><br>                        }
  ><br>                    }
  ><br>                    else imgIgual = true;
  ><br>                } while (imgIgual == false);
  
</details>
</details>
