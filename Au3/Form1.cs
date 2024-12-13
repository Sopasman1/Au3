namespace Au3
{
    public partial class Form1 : Form
    {
        // Variables para Pila
        private int[] stack = new int[10];
        private int stackTop = -1;

        // Variables para Cola
        private int[] queue = new int[10];
        private int front = 0;
        private int rear = -1;
        private int queueSize = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (stackTop < stack.Length - 1)
            {
                int value = int.Parse(txtStackInput.Text);
                stack[++stackTop] = value;
                txtStackOutput.Text = "Elemento agregado: " + value;
                txtStackInput.Clear();
            }
            else
            {
                MessageBox.Show("La pila está llena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stackTop >= 0)
            {
                int value = stack[stackTop--];
                txtStackOutput.Text = "Elemento eliminado: " + value;
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {

            if (queueSize < queue.Length)
            {
                int value = int.Parse(txtQueueInput.Text);
                rear = (rear + 1) % queue.Length;
                queue[rear] = value;
                queueSize++;
                txtQueueOutput.Text = "Elemento agregado: " + value;
                txtQueueInput.Clear();
            }
            else
            {
                MessageBox.Show("La cola está llena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (queueSize > 0)
            {
                int value = queue[front];
                front = (front + 1) % queue.Length;
                queueSize--;
                txtQueueOutput.Text = "Elemento eliminado: " + value;
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
