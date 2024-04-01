using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaSenhaAtendimento
{
    public partial class FormSenhaAtendimento : Form
    {
        Queue<string> normalQueue = new Queue<string>();
        Queue<string> preferencialQueue = new Queue<string>();
        HashSet<string> calledTickets = new HashSet<string>();

        public FormSenhaAtendimento()
        {
            InitializeComponent();
        }

        private void BTN_novaSenha_Click(object sender, EventArgs e)
        {
            normalQueue.Enqueue(GenerateTicketNumber(normalQueue));
            currentNumber.Text = normalQueue.Peek();
            calledTickets.Add(normalQueue.Peek());
            updateQueueLabel();
        }

        private void BTN_senhaPref_Click(object sender, EventArgs e)
        {
            preferencialQueue.Enqueue(GenerateTicketNumber(preferencialQueue, true));
            currentSenhaPref.Text = preferencialQueue.Peek();
            calledTickets.Add(preferencialQueue.Peek());
            updateQueueLabel();
        }

        private void BTN_chamarSenha_Click(object sender, EventArgs e)
        {
            if (preferencialQueue.Count > 0)
            {
                label3.Text = "Senha: " + preferencialQueue.Dequeue();
            }
            else if (normalQueue.Count > 0)
            {
                label3.Text = "Senha: " + normalQueue.Dequeue();
            }
            else
            {
                label3.Text = "Senha: XX";
            }
            updateQueueLabel();
        }

        private void BTN_clearQueue_Click(object sender, EventArgs e)
        {
            normalQueue.Clear();
            preferencialQueue.Clear();
            calledTickets.Clear();
            label1.Text = "NXX";
            label2.Text = "PXX";
            label3.Text = "Senha: XX";
            updateQueueLabel();
        }

        private string GenerateTicketNumber(Queue<string> queue, bool isPriority = false)
        {
            string TicketNumber;
            int count = 1;
            do { 
               TicketNumber = (isPriority ? "P" : "N") + count.ToString().PadLeft(3, '0');
                count++;
            } while (queue.Contains(TicketNumber) || calledTickets.Contains(TicketNumber));

            return TicketNumber;
        }

        private void updateQueueLabel()
        {
            fullQueue.Text = "Fila Normal: " + string.Join(", ", normalQueue) + "\nFila Preferencial: " + string.Join(", ", preferencialQueue);
        }
    }
}

