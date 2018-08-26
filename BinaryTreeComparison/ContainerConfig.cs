using Autofac;
using BinaryTreeComparison.Abstractions;
using BinaryTreeComparison.Business;

namespace BinaryTreeComparison
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TreeCompare>().As<ITreeCompare>();

            return builder.Build();
        }   
    }
}
