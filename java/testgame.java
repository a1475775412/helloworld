import java.util.*;
import java.lang.*;

class testgame{
    static boolean test = true;//是否调试
    static boolean success = false;//游戏开始 
    static Random read_random = new Random();//生成随机数字
    static int run_math = 0;//这是猜数次数
    public static void main(String[] args){
        int rad = random_Number();
        if(test){
            System.out.println("当前数" + rad);//输出当前值
        }
        while(!success){
            System.out.println("输入你猜的数！");
            Scanner scanner = new Scanner(System.in);
            int input = scanner.nextInt();//获取输入
            run_math++;//输入一次加一
            if (input == rad) {
                System.out.println("你回答正确一共输入" + run_math + "错误输入" + --run_math);
            } else {
                if (input > rad) {
                    System.out.println("大了一些");
                }
                if (input < rad) {
                    System.out.println("小了一些");
                }
            }
        }

    }
    private static int random_Number (){
        var read_ = read_random.nextInt(20);
        return read_;
       
    } 
    
}