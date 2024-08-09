namespace TestTask;

/// <summary>
/// Методы работы с треугольниками
/// </summary>
public static class TriangleMethods
{
    /// <summary>
    /// В соотстветствии с признаками остроугольного и прямогоульного треугольников и теоремы косинусов
    /// </summary>
    public static TriangleTypeEnum DetermineTriangleType(double a, double b, double c)
    {
        double[] nums = { a, b, c };
        
        Array.Sort(nums);

        a = nums[0];
        b = nums[1];
        c = nums[2];  // чтобы не возиться с тем, какая сторона длиннее

        if (c - b - a > 0)
        {
            throw new ArgumentException("Треугольник с заданными сторонами не может существовать");
        }

        if (c * c - b * b - a * a == 0)
        {
            return TriangleTypeEnum.SquareAngled;
        }

        if (c * c - b * b - a * a < 0)
        {
            return TriangleTypeEnum.AcuteAngled;
        }

        return TriangleTypeEnum.ObtuseAngled;
    }
}
