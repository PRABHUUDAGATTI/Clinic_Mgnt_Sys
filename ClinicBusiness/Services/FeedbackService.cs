using ClinicData.Repository;
using ClinicEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBusiness.Services
{
    public class FeedbackService
    {
        IFeedback _feedback;
        public FeedbackService(IFeedback feedback)
        {
            _feedback = feedback;
        }
        public void AddFeedback(Pending_Feedback pending_Feedback)
        {
            _feedback.AddFeedback(pending_Feedback);
        }
        public void DeleteFeedBack(int feedbackId)
        {
            _feedback.DeleteFeedback(feedbackId);
        }
        public void UpdateFeedback(Pending_Feedback pending_Feedback)
        {
            _feedback.UpdateFeedback(pending_Feedback);
        }
        public Pending_Feedback GetFeedbackById(int feedbackId)
        {
            return _feedback.GetFeedbackById(feedbackId);
        }
        public IEnumerable<Pending_Feedback> GetAllFeedbacks()
        {
            return _feedback.GetAllFeedbacks();
        }
    }
}
