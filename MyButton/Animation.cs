using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестирование_по_общим_дисциплинам.MyButton
{
   public class Animation
    {
        public string ID { get; set; }

        public float Value;

        public float StartValue;

        private float targetValue;
        public float TargetValue
        {
            get => targetValue;
            set
            {
                targetValue = value;
                Reverse = value < Value ? true : false;
            }
        }

        public float Volume;

        public bool Reverse = false;

        public AnimationStatus Status { get; set; }
        public enum AnimationStatus
        { 
        Reuested,
        Active,
        Completed
        }

        public float Step()
        {
            return Math.Abs(Volume) / 11;
        }

        private float ValueByPercent(float Percent)
        {
            float COEFF = Percent / 100;
            float VolumeInPercent = Volume * COEFF;
            float ValueInPercent = StartValue + VolumeInPercent;

            return ValueInPercent;
        }

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;

            if(Reverse == false)
            {
                if(Value<=targetValue)
                {
                    Value += Step();
                    if(Value>=targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= targetValue)
                {
                    Value -= Step();
                    if (Value <= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            InvalidateControl.Invoke();
        }

        public Animation() { }

        public Animation(string ID,ControlMethod InvalidateControl, float Value, float TargetValue)
        {
            this.ID = ID;

            this.InvalidateControl = InvalidateControl;

            this.Value = Value;
            this.TargetValue = TargetValue;

            StartValue = Value;
            Volume = TargetValue - Value;
        }
    }
}
