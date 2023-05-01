import React from 'react';

import cx from 'classnames';

import { HeroResponse } from '../api';
import HeroImage from './HeroImage';
import TeamHeroListHero from './TeamHeroListHero';

type TeamHeroListProps = {
  heroes: HeroResponse[];
  name: string;
  onRemove: (hero: HeroResponse) => void;
};

const TeamHeroList: React.FC<TeamHeroListProps> = (props: TeamHeroListProps) => {
  return (
    <div>
      <h2>{props.name}</h2>
      <div className='w-full flex h-20'>
        {props.heroes.map((x) => (
          <TeamHeroListHero hero={x} key={x.id} onRemove={props.onRemove} />
        ))}
      </div>
    </div>
  );
};

export default TeamHeroList;
