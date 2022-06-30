using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Тестирование_по_общим_дисциплинам.MyButton
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();
        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;

        private static double Interval;

        public static void Start()
        {
            Interval = 15;

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };
            AnimatorThread.Start();
        }
        
        public static void AnimationInvoker()
        {
            while (true)
            {
                AnimationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);

                for (int i = 0; i < AnimationList.Count; i++)
                {
                    try
                    {
                        AnimationList[i].UpdateFrame();
                    }
                    catch { }
                }

                Thread.Sleep((int)Interval);
            }
        }
        public static void Request(Animation Anim, bool ReplaceIfExistis)
        {
            Anim.Status = Animation.AnimationStatus.Reuested;

            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if(ReplaceIfExistis==true)
                {
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);
        }

        private static Animation GetDuplicate(Animation Anim)
        {
           return AnimationList.Find(a => a.ID==Anim.ID);
        }
    }
}
