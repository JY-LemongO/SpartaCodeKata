namespace CodeKata
{
    internal class Program
    {
        #region 두 수의 차
        static int solution1(int num1, int num2)
        {
            return num1 - num2;
        }
        #endregion
        #region 두 수의 곱
        static int solution2(int num1, int num2)
        {
            return num1 * num2;
        }
        #endregion
        #region 몫 구하기
        static int solution3(int num1, int num2)
        {            
            return num1 / num2;
        }
        #endregion
        #region 나이 출력
        static int solution4(int age)
        {
            return 2023 - age;
        }
        #endregion
        #region 숫자 비교하기
        static int solution5(int num1, int num2)
        {            
            return num1 == num2 ? 1 : -1;
        }
        #endregion
        #region 두 수의 합
        static int solution6(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion
        #region 7. 두 수의 나눗셈
        static int solution7(int num1, int num2)
        {
            return (int)((float)num1 / num2 * 1000);
        }
        #endregion
        #region 8. 각도기
        static int solution8(int angle)
        {
            return angle > 0 ? angle < 90 ? 1 : angle == 90 ? 2 : angle < 180 ? 3 : 4 : -1;
        }
        #endregion
        #region 9.짝수의 합
        static int solution9(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0)
                    answer += i;
            return answer;
        }
        #endregion
        static void Main(string[] args)
        {
            
        }
    }
}
