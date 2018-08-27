namespace TensorFlowDotNet.Train
{
    public class AdamOptimizer
    {
        // [PythonMethod("AdamOptimizer.__init__", File = "training/adam.py", Generate = true)]
        public AdamOptimizer(double learning_rate = 0.001, double beta1 = 0.9, double beta2 = 0.999, double epsilon = 1e-8, bool use_locking = false, string name = "Adam")
        {
        }

        [PythonMethod("AdamOptimizer._get_beta_accumulators", File = "training/adam.py", Generate = true)]
        public void GetBetaAccumulators()
        {
        }

        [PythonMethod("AdamOptimizer._create_slots", File = "training/adam.py", Generate = true)]
        public void CreateSlots(object var_list)
        {
        }

        [PythonMethod("AdamOptimizer._prepare", File = "training/adam.py", Generate = true)]
        public void Prepare()
        {
        }

        [PythonMethod("AdamOptimizer._apply_dense", File = "training/adam.py", Generate = true)]
        public void ApplyDense(object grad, object var)
        {
        }

        [PythonMethod("AdamOptimizer._resource_apply_dense", File = "training/adam.py", Generate = true)]
        public void ResourceApplyDense(object grad, object var)
        {
        }

        [PythonMethod("AdamOptimizer._apply_sparse_shared", File = "training/adam.py", Generate = true)]
        public void ApplySparseShared(object grad, object var, object indices, object scatter_add)
        {
        }

        [PythonMethod("AdamOptimizer._apply_sparse", File = "training/adam.py", Generate = true)]
        public void ApplySparse(object grad, object var)
        {
        }

        [PythonMethod("AdamOptimizer._resource_scatter_add", File = "training/adam.py", Generate = true)]
        public void ResourceScatterAdd(object x, object i, object v)
        {
        }

        [PythonMethod("AdamOptimizer._resource_apply_sparse", File = "training/adam.py", Generate = true)]
        public void ResourceApplySparse(object grad, object var, object indices)
        {
        }

        [PythonMethod("AdamOptimizer._finish", File = "training/adam.py", Generate = true)]
        public void Finish(object update_ops, object name_scope)
        {
        }
    }
}