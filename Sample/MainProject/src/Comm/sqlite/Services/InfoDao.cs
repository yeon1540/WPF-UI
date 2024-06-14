using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Comm.sqlite.Services
{
    public class InfoDao : IDataBase<Info>
    {
        private readonly DefaultContext defaultContext;
        private Info info = new Info();

        public InfoDao(DefaultContext defaultContext)
        {
            this.defaultContext = defaultContext;
        }

        #region 조회

        /// <summary>
        /// 전체 목록 가져오기
        /// </summary>
        /// <returns></returns>
        public List<Info> Get()
        {
            return this.defaultContext.Info.ToList();
        }

        /// <summary>
        /// 특정 항목 가져오기
        /// </summary>
        /// <param name="sID"></param>
        /// <returns></returns>
        public Info GetDetail(string sID)
        {
            this.info = this.defaultContext.Info.Find(sID);

            if (this.info != null)
            {
                return this.info;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// ID기준으로 오름차순으로 리스트 가져오기
        /// </summary>
        /// <returns></returns>
        public List<Info> AscOrderByGet()
        {
            return this.defaultContext.Info.OrderBy(info => info.Id).ToList();
        }

        /// <summary>
        /// ID기준으로 내림차순으로 리스트 가져오기
        /// </summary>
        /// <returns></returns>
        public List<Info> DesOrderByGet()
        {
            return this.defaultContext.Info.OrderByDescending(info => info.Id).ToList();
        }

        #endregion

        #region 추가

        /// <summary>
        /// 항목 및 데이터 새로만들기
        /// </summary>
        /// <param name="sID"></param>
        /// <param name="sData"></param>
        public void Insert(string sID, string sData)
        {
            Info col = new Info();

            this.info = this.defaultContext.Info.Find(sID);

            if (this.info == null)
            {
                col.Id = sID;
                col.Comment = sData;

                this.defaultContext.Info.Add(col);
                this.defaultContext.SaveChanges();
            }
            else
            {
                //throw new NotImplementedException();
            }
        }

        #endregion

        #region 수정

        /// <summary>
        /// 특정항목 데이터 업데이트
        /// </summary>
        /// <param name="sID"></param>
        /// <param name="sData"></param>
        public void Update(string sID, string sData)
        {
            this.info = this.defaultContext.Info.Find(sID);

            if (this.info != null)
            {
                this.info.Comment = sData;

                this.defaultContext.Info.Update(this.info);
                this.defaultContext.SaveChanges();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 한꺼번에 업데이트
        /// </summary>
        /// <param name="List"></param>
        public void Update(Info List)
        {
            foreach (var sID in List.Id)
            {
                this.info = this.defaultContext.Info.Find(sID);

                if (this.info != null)
                {
                    this.info.Comment = List.Comment;

                    this.defaultContext.Info.Update(this.info);
                    this.defaultContext.SaveChanges();
                }
            }
        }

        #endregion

        #region 삭제

        /// <summary>
        /// 특정항목 삭제
        /// </summary>
        /// <param name="sID"></param>
        public void Delete(string sID)
        {
            this.info = this.defaultContext.Info.Find(sID);

            if (this.info != null)
            {
                this.defaultContext.Info.Remove(this.info);
                this.defaultContext.SaveChanges();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
